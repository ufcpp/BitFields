using System.Collections.Immutable;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.Diagnostics;

namespace BitFieldsAnalyzer
{
    [DiagnosticAnalyzer(LanguageNames.CSharp)]
    public class BitNAnalyzer : DiagnosticAnalyzer
    {
        public const string DiagnosticId = "BitNAnalyzer";

        // You can change these strings in the Resources.resx file. If you do not want your analyzer to be localize-able, you can use regular strings for Title and MessageFormat.
        // See https://github.com/dotnet/roslyn/blob/master/docs/analyzers/Localizing%20Analyzers.md for more on localization
        private static readonly LocalizableString Title = new LocalizableResourceString(nameof(Resources.BitNAnalyzerTitle), Resources.ResourceManager, typeof(Resources));
        private static readonly LocalizableString MessageFormat = new LocalizableResourceString(nameof(Resources.BitNAnalyzerMessageFormat), Resources.ResourceManager, typeof(Resources));
        private static readonly LocalizableString Description = new LocalizableResourceString(nameof(Resources.BitNAnalyzerDescription), Resources.ResourceManager, typeof(Resources));
        private const string Category = "Syntax";

        private static DiagnosticDescriptor Rule = new DiagnosticDescriptor(DiagnosticId, Title, MessageFormat, Category, DiagnosticSeverity.Error, isEnabledByDefault: true, description: Description);

        public override ImmutableArray<DiagnosticDescriptor> SupportedDiagnostics { get { return ImmutableArray.Create(Rule); } }

        public override void Initialize(AnalysisContext context)
        {
            context.RegisterSyntaxNodeAction(AnalyzerNumericAction, SyntaxKind.NumericLiteralExpression);
        }

        private void AnalyzerNumericAction(SyntaxNodeAnalysisContext obj)
        {
            var node = (LiteralExpressionSyntax)obj.Node;
            var t = obj.SemanticModel.GetTypeInfo(node);
            var typeName = t.ConvertedType.Name;

            if(Util.MatchName(typeName) is int bits)
            {
                var num = Util.GetNumber(node.Token.Value);
                var dig = Util.Log2(num);

                if (dig > bits)
                {
                    obj.ReportDiagnostic(Diagnostic.Create(Rule, node.GetLocation(), node.Token.Text, typeName));
                }
                else
                {

                }
            }
            else
            {
                //todo: UnaryPlus + Literal: -)
                //todo: UnaryMinus + Literal: -)
                //todo: Cast + Literal: (byte)1
            }
        }
    }
}
