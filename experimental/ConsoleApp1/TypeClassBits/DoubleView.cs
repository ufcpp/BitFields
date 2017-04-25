using TypeClassBits;
using static TypeClassBits.IntConstants;
using System.Runtime.CompilerServices;

namespace ConsoleApp1.TypeClassBits
{
    struct DoubleView
    {
        public ulong Value;

        public double AsDouble() => Unsafe.As<ulong, double>(ref Value);

        public Bits<ulong, LogicalOperator64, _0, _52> Fraction => new Bits<ulong, LogicalOperator64, _0, _52>(ref Value);
        public Bits<ulong, LogicalOperator64, _52, _63> Exponent => new Bits<ulong, LogicalOperator64, _52, _63>(ref Value);
        public Bits<ulong, LogicalOperator64, _63, _64> Sign => new Bits<ulong, LogicalOperator64, _63, _64>(ref Value);

        public void Deconstruct(
            out Bits<ulong, LogicalOperator64, _0, _52> fraction,
            out Bits<ulong, LogicalOperator64, _52, _63> exponent,
            out Bits<ulong, LogicalOperator64, _63, _64> sign)
            => (fraction, exponent, sign) = (Fraction, Exponent, Sign);
    }
}
