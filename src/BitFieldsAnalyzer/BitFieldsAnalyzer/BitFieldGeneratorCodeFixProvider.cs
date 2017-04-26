using System.Collections.Immutable;
using System.Composition;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CodeFixes;
using Microsoft.CodeAnalysis.CodeActions;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.Rename;
using Microsoft.CodeAnalysis.Formatting;

namespace BitFieldsAnalyzer
{
    [ExportCodeFixProvider(LanguageNames.CSharp, Name = nameof(BitFieldGeneratorCodeFixProvider)), Shared]
    public class BitFieldGeneratorCodeFixProvider : CodeFixProvider
    {
        private const string title = "Generate bit-fields";

        public sealed override ImmutableArray<string> FixableDiagnosticIds => ImmutableArray.Create(BitFieldGeneratorAnalyzer.DiagnosticId);
        public sealed override FixAllProvider GetFixAllProvider() => WellKnownFixAllProviders.BatchFixer;

        public sealed override async Task RegisterCodeFixesAsync(CodeFixContext context)
        {
            var root = await context.Document.GetSyntaxRootAsync(context.CancellationToken).ConfigureAwait(false);

            // TODO: Replace the following code with your own analysis, generating a CodeAction for each fix to suggest
            var diagnostic = context.Diagnostics.First();
            var diagnosticSpan = diagnostic.Location.SourceSpan;

            // Find the type declaration identified by the diagnostic.
            var declaration = root.FindToken(diagnosticSpan.Start).Parent.AncestorsAndSelf().OfType<StructDeclarationSyntax>().First();

            // Register a code action that will invoke the fix.
            context.RegisterCodeFix(
                CodeAction.Create(
                    title: title,
                    createChangedSolution: c => GenerateBitFieldAsync(context.Document, declaration, c),
                    equivalenceKey: title),
                diagnostic);
        }

        private async Task<Solution> GenerateBitFieldAsync(Document document, StructDeclarationSyntax typeDecl, CancellationToken cancellationToken)
        {
            document = await AddPartialModifier(document, typeDecl, cancellationToken);
            document = await AddNewDocument(document, typeDecl, cancellationToken);

            return document.Project.Solution;
        }

        private static async Task<Document> AddPartialModifier(Document document, StructDeclarationSyntax typeDecl, CancellationToken cancellationToken)
        {
            var newTypeDecl = typeDecl.AddPartialModifier();

            var root = await document.GetSyntaxRootAsync(cancellationToken).ConfigureAwait(false) as CompilationUnitSyntax;
            var newRoolt = root.ReplaceNode(typeDecl, newTypeDecl)
                .WithAdditionalAnnotations(Formatter.Annotation);

            document = document.WithSyntaxRoot(newRoolt);
            return document;
        }

        private static async Task<Document> AddNewDocument(Document document, StructDeclarationSyntax typeDecl, CancellationToken cancellationToken)
        {
            var definition = typeDecl.ChildNodes().OfType<EnumDeclarationSyntax>().FirstOrDefault(n => n.Identifier.Text == "BitFields");

            //var newRoot = await GeneratePartialDeclaration(document, typeDecl, cancellationToken);
            var newRoot = SyntaxFactory.CompilationUnit();
            newRoot = newRoot.WithLeadingTrivia(
                SyntaxFactory.Comment("// " + string.Join(", ", definition.Members.Select(x => x.Identifier.Text + "/" + x.EqualsValue.Value.GetText())))
                );

            var name = typeDecl.Identifier.Text;
            var generatedName = name + ".BitFields.cs";

            var project = document.Project;

            var existed = project.Documents.FirstOrDefault(d => d.Name == generatedName);
            if (existed != null) return existed.WithSyntaxRoot(newRoot);
            else return project.AddDocument(generatedName, newRoot, document.Folders);
        }
    }
}