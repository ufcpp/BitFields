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
using System;
using System.Collections.Generic;
using static Microsoft.CodeAnalysis.CSharp.SyntaxFactory;

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
            var newRoot = await GeneratePartialDeclaration(document, typeDecl, cancellationToken);

            var xxx = newRoot.ToString();

            var name = typeDecl.Identifier.Text;
            var generatedName = name + ".BitFields.cs";

            var project = document.Project;

            var existed = project.Documents.FirstOrDefault(d => d.Name == generatedName);
            if (existed != null) return existed.WithSyntaxRoot(newRoot);
            else return project.AddDocument(generatedName, newRoot, document.Folders);
        }

        private static async Task<CompilationUnitSyntax> GeneratePartialDeclaration(Document document, StructDeclarationSyntax typeDecl, CancellationToken cancellationToken)
        {
            var definition = typeDecl.ChildNodes().OfType<EnumDeclarationSyntax>().FirstOrDefault(n => n.Identifier.Text == "BitFields");
            var bitfields = BitField.Create(f()).ToArray();

            IEnumerable<(string name, int bits)> f()
            {
                foreach (var m in definition.Members)
                {
                    if (m.EqualsValue.Value is LiteralExpressionSyntax literal)
                    {
                        yield return (m.Identifier.Text, (int)Util.GetNumber(literal.Token.Value));
                    }
                }
            }

            var generatedNodes = GenerateMemberDeclarations(bitfields).ToArray();

            var newTypeDecl = typeDecl.GetPartialTypeDelaration()
                .AddMembers(generatedNodes)
                .WithAdditionalAnnotations(Formatter.Annotation);

            var ns = typeDecl.FirstAncestorOrSelf<NamespaceDeclarationSyntax>()?.Name.WithoutTrivia().GetText().ToString();

            MemberDeclarationSyntax topDecl;
            if (ns != null)
            {
                topDecl = NamespaceDeclaration(IdentifierName(ns))
                    .AddMembers(newTypeDecl)
                    .WithAdditionalAnnotations(Formatter.Annotation);
            }
            else
            {
                topDecl = newTypeDecl;
            }

            var root = await document.GetSyntaxRootAsync(cancellationToken).ConfigureAwait(false) as CompilationUnitSyntax;

            return CompilationUnit()
                .AddUsings(UsingDirective(IdentifierName("BitFields")).WithTrailingTrivia(CarriageReturnLineFeed))
                .AddMembers(topDecl)
                .WithTrailingTrivia(CarriageReturnLineFeed)
                .WithAdditionalAnnotations(Formatter.Annotation);
        }

        private static IEnumerable<MemberDeclarationSyntax> GenerateMemberDeclarations(BitField[] bitfields)
        {
            var totalBits = bitfields.Last().EndBit;
            var fieldType = Util.GetCapableType(totalBits);

            yield return CSharpSyntaxTree.ParseText(
            $@"        public {fieldType} Value;
").GetRoot().ChildNodes()
                .OfType<MemberDeclarationSyntax>()
                .First()
                .WithTrailingTrivia(CarriageReturnLineFeed, CarriageReturnLineFeed)
                .WithAdditionalAnnotations(Formatter.Annotation)
                ;

            var postfix = fieldType == "ulong" ? "UL" : "U";

            foreach (var (name, start, end, bits) in bitfields)
            {
                var childNodes = CSharpSyntaxTree.ParseText(
                $@"        private const int {name}Shift = {start};
        private const {fieldType} {name}Mask = unchecked(({fieldType})((1{postfix} << {end}) - (1{postfix} << {start})));
        public Bit{bits} {name}
        {{
            get => (Bit{bits})((Value & {name}Mask) >> {name}Shift);
            set => Value = unchecked(({fieldType})((Value & ~{name}Mask) | (((({fieldType})value) << {name}Shift) & {name}Mask)));
        }}
")
                .GetRoot().ChildNodes()
                .OfType<MemberDeclarationSyntax>()
                .Select(n => n
                    .WithTrailingTrivia(CarriageReturnLineFeed)
                    .WithAdditionalAnnotations(Formatter.Annotation)
                    );

                foreach (var n in childNodes) yield return n;
            }
        }
    }
}