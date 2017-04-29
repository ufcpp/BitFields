using BitFields;

namespace ConsoleAppCore
{
    partial struct Flags
    {
        public byte Value;

        private const int AShift = 0;
        private const byte AMask = unchecked((byte)((1U << 1) - (1U << 0)));
        public Bit1 A
        {
            get => (Bit1)((Value & AMask) >> AShift);
            set => Value = unchecked((byte)((Value & ~AMask) | ((((byte)value) << AShift) & AMask)));
        }
        private const int BShift = 1;
        private const byte BMask = unchecked((byte)((1U << 2) - (1U << 1)));
        public Bit1 B
        {
            get => (Bit1)((Value & BMask) >> BShift);
            set => Value = unchecked((byte)((Value & ~BMask) | ((((byte)value) << BShift) & BMask)));
        }
        private const int CShift = 2;
        private const byte CMask = unchecked((byte)((1U << 3) - (1U << 2)));
        public Bit1 C
        {
            get => (Bit1)((Value & CMask) >> CShift);
            set => Value = unchecked((byte)((Value & ~CMask) | ((((byte)value) << CShift) & CMask)));
        }
    }
}
