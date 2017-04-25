using BitFields;
using System.Runtime.CompilerServices;

namespace ConsoleApp1.BitFields
{
    struct DoubleView
    {
        public ulong Value;

        public double AsDouble() => Unsafe.As<ulong, double>(ref Value);

        private const int FractionShift = 0;
        private const ulong FractionMask = unchecked((1UL << 52) - (1UL << 0));
        public Bit52 Fraction
        {
            get => (Bit52)((Value & FractionMask) >> FractionShift);
            set => Value = (Value & ~FractionMask) | ((((ulong)value) << FractionShift) & FractionMask);
        }

        private const int ExponentShift = 52;
        private const ulong ExponentMask = unchecked((1UL << 63) - (1UL << 52));
        public Bit11 Exponent
        {
            get => (Bit11)((Value & ExponentMask) >> ExponentShift);
            set => Value = (Value & ~ExponentMask) | ((((ulong)value) << ExponentShift) & ExponentMask);
        }

        private const int SignShift = 63;
        private const ulong SignMask = unchecked((1UL << 64) - (1UL << 63));
        public Bit1 Sign
        {
            get => (Bit1)((Value & SignMask) >> SignShift);
            set => Value = (Value & ~SignMask) | ((((ulong)value) << SignShift) & SignMask);
        }
    }
}
