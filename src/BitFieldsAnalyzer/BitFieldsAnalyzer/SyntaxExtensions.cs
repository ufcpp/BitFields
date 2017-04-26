using System.Linq;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using static Microsoft.CodeAnalysis.CSharp.SyntaxFactory;

namespace BitFieldsAnalyzer
{
    static class SyntaxExtensions
    {
        private static readonly SyntaxToken PartialToken = Token(SyntaxKind.PartialKeyword);

        public static StructDeclarationSyntax AddPartialModifier(this StructDeclarationSyntax typeDecl)
        {
            if (typeDecl.Modifiers.Any(m => m.IsKind(SyntaxKind.PartialKeyword))) return typeDecl;
            return typeDecl.AddModifiers(new[] { PartialToken });
        }

        public static StructDeclarationSyntax GetPartialTypeDelaration(this StructDeclarationSyntax typeDecl)
            => CSharpSyntaxTree.ParseText($@"
partial class {typeDecl.Identifier.Text}
{{
}}
").GetRoot().ChildNodes().OfType<StructDeclarationSyntax>().First();
    }
}
