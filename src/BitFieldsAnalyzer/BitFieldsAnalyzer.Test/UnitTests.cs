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
    public class UnitTest : DiagnosticVerifier
    {
        [Fact]
        public void TestMethod0()
        {
            var test = @"
class Program
{
    static void Main()
    {
        Bit1 x = 1;
        x = 0b100;
        x = 0xA;

        (Bit2 a1, Bit3 b1) = (-1, - 2);
        (Bit2 a, Bit3 b) = (1, 2);
    }

    Bit4 x = 1UL;
    Bit5 y = 4;

    Bit6 X { get; } = 1U;
    Bit7 Y { get; } = 2L;

    void A()
    {
        A(1);
        A(2);
    }
    void A(Bit8 x) { }
    Bit9 F() => 2;
    Bit10 Z => 2;
    Bit11 Z1 { get => 2; }
    Bit12 Z2 { get { return 2; } }
}

internal struct Bit1 { public static implicit operator Bit1(int x) => default(Bit1); }
internal struct Bit2 { public static implicit operator Bit2(int x) => default(Bit2); }
internal struct Bit3 { public static implicit operator Bit3(int x) => default(Bit3); }
internal struct Bit4 { public static implicit operator Bit4(int x) => default(Bit4); }
internal struct Bit5 { public static implicit operator Bit5(int x) => default(Bit5); }
internal struct Bit6 { public static implicit operator Bit6(int x) => default(Bit6); }
internal struct Bit7 { public static implicit operator Bit7(int x) => default(Bit7); }
internal struct Bit8 { public static implicit operator Bit8(int x) => default(Bit8); }
internal struct Bit9 { public static implicit operator Bit9(int x) => default(Bit9); }
internal struct Bit11 { public static implicit operator Bit11(int x) => default(Bit11); }
internal struct Bit12 { public static implicit operator Bit12(int x) => default(Bit12); }
internal struct Bit13 { public static implicit operator Bit13(int x) => default(Bit13); }
internal struct Bit14 { public static implicit operator Bit14(int x) => default(Bit14); }
internal struct Bit15 { public static implicit operator Bit15(int x) => default(Bit15); }
internal struct Bit16 { public static implicit operator Bit16(int x) => default(Bit16); }
internal struct Bit17 { public static implicit operator Bit17(int x) => default(Bit17); }
internal struct Bit18 { public static implicit operator Bit18(int x) => default(Bit18); }
internal struct Bit19 { public static implicit operator Bit19(int x) => default(Bit19); }
";

            var diagnostics = GetSortedDiagnostics(new[] { test }, LanguageNames.CSharp, GetCSharpDiagnosticAnalyzer());

        }

#if false

        //No diagnostics expected to show up
        [Fact]
        public void TestMethod1()
        {
            var test = @"";

            VerifyCSharpDiagnostic(test);
        }

        //Diagnostic and CodeFix both triggered and checked for
        [Fact]
        public void TestMethod2()
        {
            var test = @"
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Diagnostics;

    namespace ConsoleApplication1
    {
        class TypeName
        {   
        }
    }";
            var expected = new DiagnosticResult
            {
                Id = "BitFieldsAnalyzer",
                Message = String.Format("Type name '{0}' contains lowercase letters", "TypeName"),
                Severity = DiagnosticSeverity.Warning,
                Locations =
                    new[] {
                            new DiagnosticResultLocation("Test0.cs", 11, 15)
                        }
            };

            VerifyCSharpDiagnostic(test, expected);

            var fixtest = @"
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Diagnostics;

    namespace ConsoleApplication1
    {
        class TYPENAME
        {   
        }
    }";
            VerifyCSharpFix(test, fixtest);
        }

#endif
        protected override DiagnosticAnalyzer GetCSharpDiagnosticAnalyzer()
        {
            return new BitNAnalyzer();
        }
    }
}