namespace TypeClassBits
{
    public struct LogicalOperator8 : ILogicalOperator<byte>
    {
        public byte One => 1;
        public byte As(ulong value) => unchecked((byte)value);
        public byte Not(byte value) => unchecked((byte)~value);
        public void And(ref byte x, byte y) => x &= y;
        public void Or(ref byte x, byte y) => x |= y;
        public void LeftShift(ref byte x, int i) => x <<= i;
        public void RightShift(ref byte x, int i) => x >>= i;
        public bool IsZero(byte x) => x == 0;
    }

    public struct LogicalOperator16 : ILogicalOperator<ushort>
    {
        public ushort One => 1;
        public ushort As(ulong value) => unchecked((ushort)value);
        public ushort Not(ushort value) => unchecked((ushort)~value);
        public void And(ref ushort x, ushort y) => x &= y;
        public void Or(ref ushort x, ushort y) => x |= y;
        public void LeftShift(ref ushort x, int i) => x <<= i;
        public void RightShift(ref ushort x, int i) => x >>= i;
        public bool IsZero(ushort x) => x == 0;
    }

    public struct LogicalOperator32 : ILogicalOperator<uint>
    {
        public uint One => 1;
        public uint As(ulong value) => unchecked((uint)value);
        public uint Not(uint value) => ~value;
        public void And(ref uint x, uint y) => x &= y;
        public void Or(ref uint x, uint y) => x |= y;
        public void LeftShift(ref uint x, int i) => x <<= i;
        public void RightShift(ref uint x, int i) => x >>= i;
        public bool IsZero(uint x) => x == 0;
    }

    public struct LogicalOperator64 : ILogicalOperator<ulong>
    {
        public ulong One => 1;
        public ulong As(ulong value) => value;
        public ulong Not(ulong value) => ~value;
        public void And(ref ulong x, ulong y) => x &= y;
        public void Or(ref ulong x, ulong y) => x |= y;
        public void LeftShift(ref ulong x, int i) => x <<= i;
        public void RightShift(ref ulong x, int i) => x >>= i;
        public bool IsZero(ulong x) => x == 0;
    }

}
