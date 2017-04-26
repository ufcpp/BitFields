using System.Collections.Immutable;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.Diagnostics;
using System.Linq;

namespace BitFieldsAnalyzer
{
    [DiagnosticAnalyzer(LanguageNames.CSharp)]
    public class BitFieldGeneratorAnalyzer : DiagnosticAnalyzer
    {
        public const string DiagnosticId = "BitFieldGenerator";

        // You can change these strings in the Resources.resx file. If you do not want your analyzer to be localize-able, you can use regular strings for Title and MessageFormat.
        // See https://github.com/dotnet/roslyn/blob/master/docs/analyzers/Localizing%20Analyzers.md for more on localization
        private static readonly LocalizableString Title = new LocalizableResourceString(nameof(Resources.BitFieldGeneratorAnalyzerTitle), Resources.ResourceManager, typeof(Resources));
        private static readonly LocalizableString MessageFormat = new LocalizableResourceString(nameof(Resources.BitFieldGeneratorAnalyzerMessageFormat), Resources.ResourceManager, typeof(Resources));
        private static readonly LocalizableString Description = new LocalizableResourceString(nameof(Resources.BitFieldGeneratorAnalyzerDescription), Resources.ResourceManager, typeof(Resources));
        private const string Category = "Syntax";

        private static DiagnosticDescriptor Rule = new DiagnosticDescriptor(DiagnosticId, Title, MessageFormat, Category, DiagnosticSeverity.Info, isEnabledByDefault: true, description: Description);

        public override ImmutableArray<DiagnosticDescriptor> SupportedDiagnostics { get { return ImmutableArray.Create(Rule); } }

        public override void Initialize(AnalysisContext context)
        {
            context.RegisterSyntaxNodeAction(AnalyzerSyntax, SyntaxKind.EnumDeclaration);
        }

        private void AnalyzerSyntax(SyntaxNodeAnalysisContext context)
        {
            var s = context.Node as EnumDeclarationSyntax;
            var parent = s.FirstAncestorOrSelf<StructDeclarationSyntax>();

            if (parent == null) return;

            var name = s.Identifier.Text;
            if (name != "BitFields") return;

            if (!parent.ChildNodes().Any(n => n == s))
                return;

            var diagnostic = Diagnostic.Create(Rule, s.GetLocation(), parent.Identifier.Text);
            context.ReportDiagnostic(diagnostic);
        }
    }
}
