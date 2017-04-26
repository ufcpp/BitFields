using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CodeFixes;
using Microsoft.CodeAnalysis.Diagnostics;
using System;
using TestHelper;
using BitFieldsAnalyzer;
using Xunit;
using System.Collections.Generic;
using Microsoft.CodeAnalysis.CodeActions;
using System.Threading;

namespace BitFieldsAnalyzer.Test
{
    public class BitFieldGeneratorTest : CodeFixVerifier
    {
        [Fact]
        public void TestMethod0()
        {
            var test = @"
struct DoubleView
{
    enum BitFields
    {
        Fraction = 11,
        Exponent = 52,
        Sign = 1,
    }
}

struct Rgb555
{
    enum BitFields
    {
        B = 5,
        G = 5,
        R = 5,
    }
}
";
            VerifyCSharpFix(test, test);
        }

        protected override CodeFixProvider GetCSharpCodeFixProvider()
        {
            return new BitFieldGeneratorCodeFixProvider();
        }

        protected override DiagnosticAnalyzer GetCSharpDiagnosticAnalyzer()
        {
            return new BitFieldGeneratorAnalyzer();
        }
    }
}
