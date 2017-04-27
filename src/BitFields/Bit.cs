using System;

namespace BitFields
{
    public struct Bit1 : IEquatable<Bit1>
    {
        public byte Value;
        public Bit1 (byte  x) => Value = x;

        public bool Equals(Bit1 other) => Value == other.Value;
        public override bool Equals(object obj) => obj is Bit1 other && Equals(other);
        public override int GetHashCode() => Value.GetHashCode();
        public static bool operator ==(Bit1 x, Bit1 y) => x.Value == y.Value;
        public static bool operator !=(Bit1 x, Bit1 y) => x.Value != y.Value;

        public static implicit operator Bit1(byte x) => new Bit1(x);
        public static implicit operator byte(Bit1 x) => x.Value;

        public override string ToString() => Value.ToString();
    }
    public struct Bit2 : IEquatable<Bit2>
    {
        public byte Value;
        public Bit2 (byte  x) => Value = x;

        public bool Equals(Bit2 other) => Value == other.Value;
        public override bool Equals(object obj) => obj is Bit2 other && Equals(other);
        public override int GetHashCode() => Value.GetHashCode();
        public static bool operator ==(Bit2 x, Bit2 y) => x.Value == y.Value;
        public static bool operator !=(Bit2 x, Bit2 y) => x.Value != y.Value;

        public static implicit operator Bit2(byte x) => new Bit2(x);
        public static implicit operator byte(Bit2 x) => x.Value;

        public override string ToString() => Value.ToString();
    }
    public struct Bit3 : IEquatable<Bit3>
    {
        public byte Value;
        public Bit3 (byte  x) => Value = x;

        public bool Equals(Bit3 other) => Value == other.Value;
        public override bool Equals(object obj) => obj is Bit3 other && Equals(other);
        public override int GetHashCode() => Value.GetHashCode();
        public static bool operator ==(Bit3 x, Bit3 y) => x.Value == y.Value;
        public static bool operator !=(Bit3 x, Bit3 y) => x.Value != y.Value;

        public static implicit operator Bit3(byte x) => new Bit3(x);
        public static implicit operator byte(Bit3 x) => x.Value;

        public override string ToString() => Value.ToString();
    }
    public struct Bit4 : IEquatable<Bit4>
    {
        public byte Value;
        public Bit4 (byte  x) => Value = x;

        public bool Equals(Bit4 other) => Value == other.Value;
        public override bool Equals(object obj) => obj is Bit4 other && Equals(other);
        public override int GetHashCode() => Value.GetHashCode();
        public static bool operator ==(Bit4 x, Bit4 y) => x.Value == y.Value;
        public static bool operator !=(Bit4 x, Bit4 y) => x.Value != y.Value;

        public static implicit operator Bit4(byte x) => new Bit4(x);
        public static implicit operator byte(Bit4 x) => x.Value;

        public override string ToString() => Value.ToString();
    }
    public struct Bit5 : IEquatable<Bit5>
    {
        public byte Value;
        public Bit5 (byte  x) => Value = x;

        public bool Equals(Bit5 other) => Value == other.Value;
        public override bool Equals(object obj) => obj is Bit5 other && Equals(other);
        public override int GetHashCode() => Value.GetHashCode();
        public static bool operator ==(Bit5 x, Bit5 y) => x.Value == y.Value;
        public static bool operator !=(Bit5 x, Bit5 y) => x.Value != y.Value;

        public static implicit operator Bit5(byte x) => new Bit5(x);
        public static implicit operator byte(Bit5 x) => x.Value;

        public override string ToString() => Value.ToString();
    }
    public struct Bit6 : IEquatable<Bit6>
    {
        public byte Value;
        public Bit6 (byte  x) => Value = x;

        public bool Equals(Bit6 other) => Value == other.Value;
        public override bool Equals(object obj) => obj is Bit6 other && Equals(other);
        public override int GetHashCode() => Value.GetHashCode();
        public static bool operator ==(Bit6 x, Bit6 y) => x.Value == y.Value;
        public static bool operator !=(Bit6 x, Bit6 y) => x.Value != y.Value;

        public static implicit operator Bit6(byte x) => new Bit6(x);
        public static implicit operator byte(Bit6 x) => x.Value;

        public override string ToString() => Value.ToString();
    }
    public struct Bit7 : IEquatable<Bit7>
    {
        public byte Value;
        public Bit7 (byte  x) => Value = x;

        public bool Equals(Bit7 other) => Value == other.Value;
        public override bool Equals(object obj) => obj is Bit7 other && Equals(other);
        public override int GetHashCode() => Value.GetHashCode();
        public static bool operator ==(Bit7 x, Bit7 y) => x.Value == y.Value;
        public static bool operator !=(Bit7 x, Bit7 y) => x.Value != y.Value;

        public static implicit operator Bit7(byte x) => new Bit7(x);
        public static implicit operator byte(Bit7 x) => x.Value;

        public override string ToString() => Value.ToString();
    }
    public struct Bit8 : IEquatable<Bit8>
    {
        public byte Value;
        public Bit8 (byte  x) => Value = x;

        public bool Equals(Bit8 other) => Value == other.Value;
        public override bool Equals(object obj) => obj is Bit8 other && Equals(other);
        public override int GetHashCode() => Value.GetHashCode();
        public static bool operator ==(Bit8 x, Bit8 y) => x.Value == y.Value;
        public static bool operator !=(Bit8 x, Bit8 y) => x.Value != y.Value;

        public static implicit operator Bit8(byte x) => new Bit8(x);
        public static implicit operator byte(Bit8 x) => x.Value;

        public override string ToString() => Value.ToString();
    }
    public struct Bit9 : IEquatable<Bit9>
    {
        public ushort Value;
        public Bit9 (ushort  x) => Value = x;

        public bool Equals(Bit9 other) => Value == other.Value;
        public override bool Equals(object obj) => obj is Bit9 other && Equals(other);
        public override int GetHashCode() => Value.GetHashCode();
        public static bool operator ==(Bit9 x, Bit9 y) => x.Value == y.Value;
        public static bool operator !=(Bit9 x, Bit9 y) => x.Value != y.Value;

        public static implicit operator Bit9(ushort x) => new Bit9(x);
        public static implicit operator ushort(Bit9 x) => x.Value;

        public override string ToString() => Value.ToString();
    }
    public struct Bit10 : IEquatable<Bit10>
    {
        public ushort Value;
        public Bit10 (ushort  x) => Value = x;

        public bool Equals(Bit10 other) => Value == other.Value;
        public override bool Equals(object obj) => obj is Bit10 other && Equals(other);
        public override int GetHashCode() => Value.GetHashCode();
        public static bool operator ==(Bit10 x, Bit10 y) => x.Value == y.Value;
        public static bool operator !=(Bit10 x, Bit10 y) => x.Value != y.Value;

        public static implicit operator Bit10(ushort x) => new Bit10(x);
        public static implicit operator ushort(Bit10 x) => x.Value;

        public override string ToString() => Value.ToString();
    }
    public struct Bit11 : IEquatable<Bit11>
    {
        public ushort Value;
        public Bit11 (ushort  x) => Value = x;

        public bool Equals(Bit11 other) => Value == other.Value;
        public override bool Equals(object obj) => obj is Bit11 other && Equals(other);
        public override int GetHashCode() => Value.GetHashCode();
        public static bool operator ==(Bit11 x, Bit11 y) => x.Value == y.Value;
        public static bool operator !=(Bit11 x, Bit11 y) => x.Value != y.Value;

        public static implicit operator Bit11(ushort x) => new Bit11(x);
        public static implicit operator ushort(Bit11 x) => x.Value;

        public override string ToString() => Value.ToString();
    }
    public struct Bit12 : IEquatable<Bit12>
    {
        public ushort Value;
        public Bit12 (ushort  x) => Value = x;

        public bool Equals(Bit12 other) => Value == other.Value;
        public override bool Equals(object obj) => obj is Bit12 other && Equals(other);
        public override int GetHashCode() => Value.GetHashCode();
        public static bool operator ==(Bit12 x, Bit12 y) => x.Value == y.Value;
        public static bool operator !=(Bit12 x, Bit12 y) => x.Value != y.Value;

        public static implicit operator Bit12(ushort x) => new Bit12(x);
        public static implicit operator ushort(Bit12 x) => x.Value;

        public override string ToString() => Value.ToString();
    }
    public struct Bit13 : IEquatable<Bit13>
    {
        public ushort Value;
        public Bit13 (ushort  x) => Value = x;

        public bool Equals(Bit13 other) => Value == other.Value;
        public override bool Equals(object obj) => obj is Bit13 other && Equals(other);
        public override int GetHashCode() => Value.GetHashCode();
        public static bool operator ==(Bit13 x, Bit13 y) => x.Value == y.Value;
        public static bool operator !=(Bit13 x, Bit13 y) => x.Value != y.Value;

        public static implicit operator Bit13(ushort x) => new Bit13(x);
        public static implicit operator ushort(Bit13 x) => x.Value;

        public override string ToString() => Value.ToString();
    }
    public struct Bit14 : IEquatable<Bit14>
    {
        public ushort Value;
        public Bit14 (ushort  x) => Value = x;

        public bool Equals(Bit14 other) => Value == other.Value;
        public override bool Equals(object obj) => obj is Bit14 other && Equals(other);
        public override int GetHashCode() => Value.GetHashCode();
        public static bool operator ==(Bit14 x, Bit14 y) => x.Value == y.Value;
        public static bool operator !=(Bit14 x, Bit14 y) => x.Value != y.Value;

        public static implicit operator Bit14(ushort x) => new Bit14(x);
        public static implicit operator ushort(Bit14 x) => x.Value;

        public override string ToString() => Value.ToString();
    }
    public struct Bit15 : IEquatable<Bit15>
    {
        public ushort Value;
        public Bit15 (ushort  x) => Value = x;

        public bool Equals(Bit15 other) => Value == other.Value;
        public override bool Equals(object obj) => obj is Bit15 other && Equals(other);
        public override int GetHashCode() => Value.GetHashCode();
        public static bool operator ==(Bit15 x, Bit15 y) => x.Value == y.Value;
        public static bool operator !=(Bit15 x, Bit15 y) => x.Value != y.Value;

        public static implicit operator Bit15(ushort x) => new Bit15(x);
        public static implicit operator ushort(Bit15 x) => x.Value;

        public override string ToString() => Value.ToString();
    }
    public struct Bit16 : IEquatable<Bit16>
    {
        public ushort Value;
        public Bit16 (ushort  x) => Value = x;

        public bool Equals(Bit16 other) => Value == other.Value;
        public override bool Equals(object obj) => obj is Bit16 other && Equals(other);
        public override int GetHashCode() => Value.GetHashCode();
        public static bool operator ==(Bit16 x, Bit16 y) => x.Value == y.Value;
        public static bool operator !=(Bit16 x, Bit16 y) => x.Value != y.Value;

        public static implicit operator Bit16(ushort x) => new Bit16(x);
        public static implicit operator ushort(Bit16 x) => x.Value;

        public override string ToString() => Value.ToString();
    }
    public struct Bit17 : IEquatable<Bit17>
    {
        public uint Value;
        public Bit17 (uint  x) => Value = x;

        public bool Equals(Bit17 other) => Value == other.Value;
        public override bool Equals(object obj) => obj is Bit17 other && Equals(other);
        public override int GetHashCode() => Value.GetHashCode();
        public static bool operator ==(Bit17 x, Bit17 y) => x.Value == y.Value;
        public static bool operator !=(Bit17 x, Bit17 y) => x.Value != y.Value;

        public static implicit operator Bit17(uint x) => new Bit17(x);
        public static implicit operator uint(Bit17 x) => x.Value;

        public override string ToString() => Value.ToString();
    }
    public struct Bit18 : IEquatable<Bit18>
    {
        public uint Value;
        public Bit18 (uint  x) => Value = x;

        public bool Equals(Bit18 other) => Value == other.Value;
        public override bool Equals(object obj) => obj is Bit18 other && Equals(other);
        public override int GetHashCode() => Value.GetHashCode();
        public static bool operator ==(Bit18 x, Bit18 y) => x.Value == y.Value;
        public static bool operator !=(Bit18 x, Bit18 y) => x.Value != y.Value;

        public static implicit operator Bit18(uint x) => new Bit18(x);
        public static implicit operator uint(Bit18 x) => x.Value;

        public override string ToString() => Value.ToString();
    }
    public struct Bit19 : IEquatable<Bit19>
    {
        public uint Value;
        public Bit19 (uint  x) => Value = x;

        public bool Equals(Bit19 other) => Value == other.Value;
        public override bool Equals(object obj) => obj is Bit19 other && Equals(other);
        public override int GetHashCode() => Value.GetHashCode();
        public static bool operator ==(Bit19 x, Bit19 y) => x.Value == y.Value;
        public static bool operator !=(Bit19 x, Bit19 y) => x.Value != y.Value;

        public static implicit operator Bit19(uint x) => new Bit19(x);
        public static implicit operator uint(Bit19 x) => x.Value;

        public override string ToString() => Value.ToString();
    }
    public struct Bit20 : IEquatable<Bit20>
    {
        public uint Value;
        public Bit20 (uint  x) => Value = x;

        public bool Equals(Bit20 other) => Value == other.Value;
        public override bool Equals(object obj) => obj is Bit20 other && Equals(other);
        public override int GetHashCode() => Value.GetHashCode();
        public static bool operator ==(Bit20 x, Bit20 y) => x.Value == y.Value;
        public static bool operator !=(Bit20 x, Bit20 y) => x.Value != y.Value;

        public static implicit operator Bit20(uint x) => new Bit20(x);
        public static implicit operator uint(Bit20 x) => x.Value;

        public override string ToString() => Value.ToString();
    }
    public struct Bit21 : IEquatable<Bit21>
    {
        public uint Value;
        public Bit21 (uint  x) => Value = x;

        public bool Equals(Bit21 other) => Value == other.Value;
        public override bool Equals(object obj) => obj is Bit21 other && Equals(other);
        public override int GetHashCode() => Value.GetHashCode();
        public static bool operator ==(Bit21 x, Bit21 y) => x.Value == y.Value;
        public static bool operator !=(Bit21 x, Bit21 y) => x.Value != y.Value;

        public static implicit operator Bit21(uint x) => new Bit21(x);
        public static implicit operator uint(Bit21 x) => x.Value;

        public override string ToString() => Value.ToString();
    }
    public struct Bit22 : IEquatable<Bit22>
    {
        public uint Value;
        public Bit22 (uint  x) => Value = x;

        public bool Equals(Bit22 other) => Value == other.Value;
        public override bool Equals(object obj) => obj is Bit22 other && Equals(other);
        public override int GetHashCode() => Value.GetHashCode();
        public static bool operator ==(Bit22 x, Bit22 y) => x.Value == y.Value;
        public static bool operator !=(Bit22 x, Bit22 y) => x.Value != y.Value;

        public static implicit operator Bit22(uint x) => new Bit22(x);
        public static implicit operator uint(Bit22 x) => x.Value;

        public override string ToString() => Value.ToString();
    }
    public struct Bit23 : IEquatable<Bit23>
    {
        public uint Value;
        public Bit23 (uint  x) => Value = x;

        public bool Equals(Bit23 other) => Value == other.Value;
        public override bool Equals(object obj) => obj is Bit23 other && Equals(other);
        public override int GetHashCode() => Value.GetHashCode();
        public static bool operator ==(Bit23 x, Bit23 y) => x.Value == y.Value;
        public static bool operator !=(Bit23 x, Bit23 y) => x.Value != y.Value;

        public static implicit operator Bit23(uint x) => new Bit23(x);
        public static implicit operator uint(Bit23 x) => x.Value;

        public override string ToString() => Value.ToString();
    }
    public struct Bit24 : IEquatable<Bit24>
    {
        public uint Value;
        public Bit24 (uint  x) => Value = x;

        public bool Equals(Bit24 other) => Value == other.Value;
        public override bool Equals(object obj) => obj is Bit24 other && Equals(other);
        public override int GetHashCode() => Value.GetHashCode();
        public static bool operator ==(Bit24 x, Bit24 y) => x.Value == y.Value;
        public static bool operator !=(Bit24 x, Bit24 y) => x.Value != y.Value;

        public static implicit operator Bit24(uint x) => new Bit24(x);
        public static implicit operator uint(Bit24 x) => x.Value;

        public override string ToString() => Value.ToString();
    }
    public struct Bit25 : IEquatable<Bit25>
    {
        public uint Value;
        public Bit25 (uint  x) => Value = x;

        public bool Equals(Bit25 other) => Value == other.Value;
        public override bool Equals(object obj) => obj is Bit25 other && Equals(other);
        public override int GetHashCode() => Value.GetHashCode();
        public static bool operator ==(Bit25 x, Bit25 y) => x.Value == y.Value;
        public static bool operator !=(Bit25 x, Bit25 y) => x.Value != y.Value;

        public static implicit operator Bit25(uint x) => new Bit25(x);
        public static implicit operator uint(Bit25 x) => x.Value;

        public override string ToString() => Value.ToString();
    }
    public struct Bit26 : IEquatable<Bit26>
    {
        public uint Value;
        public Bit26 (uint  x) => Value = x;

        public bool Equals(Bit26 other) => Value == other.Value;
        public override bool Equals(object obj) => obj is Bit26 other && Equals(other);
        public override int GetHashCode() => Value.GetHashCode();
        public static bool operator ==(Bit26 x, Bit26 y) => x.Value == y.Value;
        public static bool operator !=(Bit26 x, Bit26 y) => x.Value != y.Value;

        public static implicit operator Bit26(uint x) => new Bit26(x);
        public static implicit operator uint(Bit26 x) => x.Value;

        public override string ToString() => Value.ToString();
    }
    public struct Bit27 : IEquatable<Bit27>
    {
        public uint Value;
        public Bit27 (uint  x) => Value = x;

        public bool Equals(Bit27 other) => Value == other.Value;
        public override bool Equals(object obj) => obj is Bit27 other && Equals(other);
        public override int GetHashCode() => Value.GetHashCode();
        public static bool operator ==(Bit27 x, Bit27 y) => x.Value == y.Value;
        public static bool operator !=(Bit27 x, Bit27 y) => x.Value != y.Value;

        public static implicit operator Bit27(uint x) => new Bit27(x);
        public static implicit operator uint(Bit27 x) => x.Value;

        public override string ToString() => Value.ToString();
    }
    public struct Bit28 : IEquatable<Bit28>
    {
        public uint Value;
        public Bit28 (uint  x) => Value = x;

        public bool Equals(Bit28 other) => Value == other.Value;
        public override bool Equals(object obj) => obj is Bit28 other && Equals(other);
        public override int GetHashCode() => Value.GetHashCode();
        public static bool operator ==(Bit28 x, Bit28 y) => x.Value == y.Value;
        public static bool operator !=(Bit28 x, Bit28 y) => x.Value != y.Value;

        public static implicit operator Bit28(uint x) => new Bit28(x);
        public static implicit operator uint(Bit28 x) => x.Value;

        public override string ToString() => Value.ToString();
    }
    public struct Bit29 : IEquatable<Bit29>
    {
        public uint Value;
        public Bit29 (uint  x) => Value = x;

        public bool Equals(Bit29 other) => Value == other.Value;
        public override bool Equals(object obj) => obj is Bit29 other && Equals(other);
        public override int GetHashCode() => Value.GetHashCode();
        public static bool operator ==(Bit29 x, Bit29 y) => x.Value == y.Value;
        public static bool operator !=(Bit29 x, Bit29 y) => x.Value != y.Value;

        public static implicit operator Bit29(uint x) => new Bit29(x);
        public static implicit operator uint(Bit29 x) => x.Value;

        public override string ToString() => Value.ToString();
    }
    public struct Bit30 : IEquatable<Bit30>
    {
        public uint Value;
        public Bit30 (uint  x) => Value = x;

        public bool Equals(Bit30 other) => Value == other.Value;
        public override bool Equals(object obj) => obj is Bit30 other && Equals(other);
        public override int GetHashCode() => Value.GetHashCode();
        public static bool operator ==(Bit30 x, Bit30 y) => x.Value == y.Value;
        public static bool operator !=(Bit30 x, Bit30 y) => x.Value != y.Value;

        public static implicit operator Bit30(uint x) => new Bit30(x);
        public static implicit operator uint(Bit30 x) => x.Value;

        public override string ToString() => Value.ToString();
    }
    public struct Bit31 : IEquatable<Bit31>
    {
        public uint Value;
        public Bit31 (uint  x) => Value = x;

        public bool Equals(Bit31 other) => Value == other.Value;
        public override bool Equals(object obj) => obj is Bit31 other && Equals(other);
        public override int GetHashCode() => Value.GetHashCode();
        public static bool operator ==(Bit31 x, Bit31 y) => x.Value == y.Value;
        public static bool operator !=(Bit31 x, Bit31 y) => x.Value != y.Value;

        public static implicit operator Bit31(uint x) => new Bit31(x);
        public static implicit operator uint(Bit31 x) => x.Value;

        public override string ToString() => Value.ToString();
    }
    public struct Bit32 : IEquatable<Bit32>
    {
        public uint Value;
        public Bit32 (uint  x) => Value = x;

        public bool Equals(Bit32 other) => Value == other.Value;
        public override bool Equals(object obj) => obj is Bit32 other && Equals(other);
        public override int GetHashCode() => Value.GetHashCode();
        public static bool operator ==(Bit32 x, Bit32 y) => x.Value == y.Value;
        public static bool operator !=(Bit32 x, Bit32 y) => x.Value != y.Value;

        public static implicit operator Bit32(uint x) => new Bit32(x);
        public static implicit operator uint(Bit32 x) => x.Value;

        public override string ToString() => Value.ToString();
    }
    public struct Bit33 : IEquatable<Bit33>
    {
        public ulong Value;
        public Bit33 (ulong  x) => Value = x;

        public bool Equals(Bit33 other) => Value == other.Value;
        public override bool Equals(object obj) => obj is Bit33 other && Equals(other);
        public override int GetHashCode() => Value.GetHashCode();
        public static bool operator ==(Bit33 x, Bit33 y) => x.Value == y.Value;
        public static bool operator !=(Bit33 x, Bit33 y) => x.Value != y.Value;

        public static implicit operator Bit33(ulong x) => new Bit33(x);
        public static implicit operator ulong(Bit33 x) => x.Value;

        public override string ToString() => Value.ToString();
    }
    public struct Bit34 : IEquatable<Bit34>
    {
        public ulong Value;
        public Bit34 (ulong  x) => Value = x;

        public bool Equals(Bit34 other) => Value == other.Value;
        public override bool Equals(object obj) => obj is Bit34 other && Equals(other);
        public override int GetHashCode() => Value.GetHashCode();
        public static bool operator ==(Bit34 x, Bit34 y) => x.Value == y.Value;
        public static bool operator !=(Bit34 x, Bit34 y) => x.Value != y.Value;

        public static implicit operator Bit34(ulong x) => new Bit34(x);
        public static implicit operator ulong(Bit34 x) => x.Value;

        public override string ToString() => Value.ToString();
    }
    public struct Bit35 : IEquatable<Bit35>
    {
        public ulong Value;
        public Bit35 (ulong  x) => Value = x;

        public bool Equals(Bit35 other) => Value == other.Value;
        public override bool Equals(object obj) => obj is Bit35 other && Equals(other);
        public override int GetHashCode() => Value.GetHashCode();
        public static bool operator ==(Bit35 x, Bit35 y) => x.Value == y.Value;
        public static bool operator !=(Bit35 x, Bit35 y) => x.Value != y.Value;

        public static implicit operator Bit35(ulong x) => new Bit35(x);
        public static implicit operator ulong(Bit35 x) => x.Value;

        public override string ToString() => Value.ToString();
    }
    public struct Bit36 : IEquatable<Bit36>
    {
        public ulong Value;
        public Bit36 (ulong  x) => Value = x;

        public bool Equals(Bit36 other) => Value == other.Value;
        public override bool Equals(object obj) => obj is Bit36 other && Equals(other);
        public override int GetHashCode() => Value.GetHashCode();
        public static bool operator ==(Bit36 x, Bit36 y) => x.Value == y.Value;
        public static bool operator !=(Bit36 x, Bit36 y) => x.Value != y.Value;

        public static implicit operator Bit36(ulong x) => new Bit36(x);
        public static implicit operator ulong(Bit36 x) => x.Value;

        public override string ToString() => Value.ToString();
    }
    public struct Bit37 : IEquatable<Bit37>
    {
        public ulong Value;
        public Bit37 (ulong  x) => Value = x;

        public bool Equals(Bit37 other) => Value == other.Value;
        public override bool Equals(object obj) => obj is Bit37 other && Equals(other);
        public override int GetHashCode() => Value.GetHashCode();
        public static bool operator ==(Bit37 x, Bit37 y) => x.Value == y.Value;
        public static bool operator !=(Bit37 x, Bit37 y) => x.Value != y.Value;

        public static implicit operator Bit37(ulong x) => new Bit37(x);
        public static implicit operator ulong(Bit37 x) => x.Value;

        public override string ToString() => Value.ToString();
    }
    public struct Bit38 : IEquatable<Bit38>
    {
        public ulong Value;
        public Bit38 (ulong  x) => Value = x;

        public bool Equals(Bit38 other) => Value == other.Value;
        public override bool Equals(object obj) => obj is Bit38 other && Equals(other);
        public override int GetHashCode() => Value.GetHashCode();
        public static bool operator ==(Bit38 x, Bit38 y) => x.Value == y.Value;
        public static bool operator !=(Bit38 x, Bit38 y) => x.Value != y.Value;

        public static implicit operator Bit38(ulong x) => new Bit38(x);
        public static implicit operator ulong(Bit38 x) => x.Value;

        public override string ToString() => Value.ToString();
    }
    public struct Bit39 : IEquatable<Bit39>
    {
        public ulong Value;
        public Bit39 (ulong  x) => Value = x;

        public bool Equals(Bit39 other) => Value == other.Value;
        public override bool Equals(object obj) => obj is Bit39 other && Equals(other);
        public override int GetHashCode() => Value.GetHashCode();
        public static bool operator ==(Bit39 x, Bit39 y) => x.Value == y.Value;
        public static bool operator !=(Bit39 x, Bit39 y) => x.Value != y.Value;

        public static implicit operator Bit39(ulong x) => new Bit39(x);
        public static implicit operator ulong(Bit39 x) => x.Value;

        public override string ToString() => Value.ToString();
    }
    public struct Bit40 : IEquatable<Bit40>
    {
        public ulong Value;
        public Bit40 (ulong  x) => Value = x;

        public bool Equals(Bit40 other) => Value == other.Value;
        public override bool Equals(object obj) => obj is Bit40 other && Equals(other);
        public override int GetHashCode() => Value.GetHashCode();
        public static bool operator ==(Bit40 x, Bit40 y) => x.Value == y.Value;
        public static bool operator !=(Bit40 x, Bit40 y) => x.Value != y.Value;

        public static implicit operator Bit40(ulong x) => new Bit40(x);
        public static implicit operator ulong(Bit40 x) => x.Value;

        public override string ToString() => Value.ToString();
    }
    public struct Bit41 : IEquatable<Bit41>
    {
        public ulong Value;
        public Bit41 (ulong  x) => Value = x;

        public bool Equals(Bit41 other) => Value == other.Value;
        public override bool Equals(object obj) => obj is Bit41 other && Equals(other);
        public override int GetHashCode() => Value.GetHashCode();
        public static bool operator ==(Bit41 x, Bit41 y) => x.Value == y.Value;
        public static bool operator !=(Bit41 x, Bit41 y) => x.Value != y.Value;

        public static implicit operator Bit41(ulong x) => new Bit41(x);
        public static implicit operator ulong(Bit41 x) => x.Value;

        public override string ToString() => Value.ToString();
    }
    public struct Bit42 : IEquatable<Bit42>
    {
        public ulong Value;
        public Bit42 (ulong  x) => Value = x;

        public bool Equals(Bit42 other) => Value == other.Value;
        public override bool Equals(object obj) => obj is Bit42 other && Equals(other);
        public override int GetHashCode() => Value.GetHashCode();
        public static bool operator ==(Bit42 x, Bit42 y) => x.Value == y.Value;
        public static bool operator !=(Bit42 x, Bit42 y) => x.Value != y.Value;

        public static implicit operator Bit42(ulong x) => new Bit42(x);
        public static implicit operator ulong(Bit42 x) => x.Value;

        public override string ToString() => Value.ToString();
    }
    public struct Bit43 : IEquatable<Bit43>
    {
        public ulong Value;
        public Bit43 (ulong  x) => Value = x;

        public bool Equals(Bit43 other) => Value == other.Value;
        public override bool Equals(object obj) => obj is Bit43 other && Equals(other);
        public override int GetHashCode() => Value.GetHashCode();
        public static bool operator ==(Bit43 x, Bit43 y) => x.Value == y.Value;
        public static bool operator !=(Bit43 x, Bit43 y) => x.Value != y.Value;

        public static implicit operator Bit43(ulong x) => new Bit43(x);
        public static implicit operator ulong(Bit43 x) => x.Value;

        public override string ToString() => Value.ToString();
    }
    public struct Bit44 : IEquatable<Bit44>
    {
        public ulong Value;
        public Bit44 (ulong  x) => Value = x;

        public bool Equals(Bit44 other) => Value == other.Value;
        public override bool Equals(object obj) => obj is Bit44 other && Equals(other);
        public override int GetHashCode() => Value.GetHashCode();
        public static bool operator ==(Bit44 x, Bit44 y) => x.Value == y.Value;
        public static bool operator !=(Bit44 x, Bit44 y) => x.Value != y.Value;

        public static implicit operator Bit44(ulong x) => new Bit44(x);
        public static implicit operator ulong(Bit44 x) => x.Value;

        public override string ToString() => Value.ToString();
    }
    public struct Bit45 : IEquatable<Bit45>
    {
        public ulong Value;
        public Bit45 (ulong  x) => Value = x;

        public bool Equals(Bit45 other) => Value == other.Value;
        public override bool Equals(object obj) => obj is Bit45 other && Equals(other);
        public override int GetHashCode() => Value.GetHashCode();
        public static bool operator ==(Bit45 x, Bit45 y) => x.Value == y.Value;
        public static bool operator !=(Bit45 x, Bit45 y) => x.Value != y.Value;

        public static implicit operator Bit45(ulong x) => new Bit45(x);
        public static implicit operator ulong(Bit45 x) => x.Value;

        public override string ToString() => Value.ToString();
    }
    public struct Bit46 : IEquatable<Bit46>
    {
        public ulong Value;
        public Bit46 (ulong  x) => Value = x;

        public bool Equals(Bit46 other) => Value == other.Value;
        public override bool Equals(object obj) => obj is Bit46 other && Equals(other);
        public override int GetHashCode() => Value.GetHashCode();
        public static bool operator ==(Bit46 x, Bit46 y) => x.Value == y.Value;
        public static bool operator !=(Bit46 x, Bit46 y) => x.Value != y.Value;

        public static implicit operator Bit46(ulong x) => new Bit46(x);
        public static implicit operator ulong(Bit46 x) => x.Value;

        public override string ToString() => Value.ToString();
    }
    public struct Bit47 : IEquatable<Bit47>
    {
        public ulong Value;
        public Bit47 (ulong  x) => Value = x;

        public bool Equals(Bit47 other) => Value == other.Value;
        public override bool Equals(object obj) => obj is Bit47 other && Equals(other);
        public override int GetHashCode() => Value.GetHashCode();
        public static bool operator ==(Bit47 x, Bit47 y) => x.Value == y.Value;
        public static bool operator !=(Bit47 x, Bit47 y) => x.Value != y.Value;

        public static implicit operator Bit47(ulong x) => new Bit47(x);
        public static implicit operator ulong(Bit47 x) => x.Value;

        public override string ToString() => Value.ToString();
    }
    public struct Bit48 : IEquatable<Bit48>
    {
        public ulong Value;
        public Bit48 (ulong  x) => Value = x;

        public bool Equals(Bit48 other) => Value == other.Value;
        public override bool Equals(object obj) => obj is Bit48 other && Equals(other);
        public override int GetHashCode() => Value.GetHashCode();
        public static bool operator ==(Bit48 x, Bit48 y) => x.Value == y.Value;
        public static bool operator !=(Bit48 x, Bit48 y) => x.Value != y.Value;

        public static implicit operator Bit48(ulong x) => new Bit48(x);
        public static implicit operator ulong(Bit48 x) => x.Value;

        public override string ToString() => Value.ToString();
    }
    public struct Bit49 : IEquatable<Bit49>
    {
        public ulong Value;
        public Bit49 (ulong  x) => Value = x;

        public bool Equals(Bit49 other) => Value == other.Value;
        public override bool Equals(object obj) => obj is Bit49 other && Equals(other);
        public override int GetHashCode() => Value.GetHashCode();
        public static bool operator ==(Bit49 x, Bit49 y) => x.Value == y.Value;
        public static bool operator !=(Bit49 x, Bit49 y) => x.Value != y.Value;

        public static implicit operator Bit49(ulong x) => new Bit49(x);
        public static implicit operator ulong(Bit49 x) => x.Value;

        public override string ToString() => Value.ToString();
    }
    public struct Bit50 : IEquatable<Bit50>
    {
        public ulong Value;
        public Bit50 (ulong  x) => Value = x;

        public bool Equals(Bit50 other) => Value == other.Value;
        public override bool Equals(object obj) => obj is Bit50 other && Equals(other);
        public override int GetHashCode() => Value.GetHashCode();
        public static bool operator ==(Bit50 x, Bit50 y) => x.Value == y.Value;
        public static bool operator !=(Bit50 x, Bit50 y) => x.Value != y.Value;

        public static implicit operator Bit50(ulong x) => new Bit50(x);
        public static implicit operator ulong(Bit50 x) => x.Value;

        public override string ToString() => Value.ToString();
    }
    public struct Bit51 : IEquatable<Bit51>
    {
        public ulong Value;
        public Bit51 (ulong  x) => Value = x;

        public bool Equals(Bit51 other) => Value == other.Value;
        public override bool Equals(object obj) => obj is Bit51 other && Equals(other);
        public override int GetHashCode() => Value.GetHashCode();
        public static bool operator ==(Bit51 x, Bit51 y) => x.Value == y.Value;
        public static bool operator !=(Bit51 x, Bit51 y) => x.Value != y.Value;

        public static implicit operator Bit51(ulong x) => new Bit51(x);
        public static implicit operator ulong(Bit51 x) => x.Value;

        public override string ToString() => Value.ToString();
    }
    public struct Bit52 : IEquatable<Bit52>
    {
        public ulong Value;
        public Bit52 (ulong  x) => Value = x;

        public bool Equals(Bit52 other) => Value == other.Value;
        public override bool Equals(object obj) => obj is Bit52 other && Equals(other);
        public override int GetHashCode() => Value.GetHashCode();
        public static bool operator ==(Bit52 x, Bit52 y) => x.Value == y.Value;
        public static bool operator !=(Bit52 x, Bit52 y) => x.Value != y.Value;

        public static implicit operator Bit52(ulong x) => new Bit52(x);
        public static implicit operator ulong(Bit52 x) => x.Value;

        public override string ToString() => Value.ToString();
    }
    public struct Bit53 : IEquatable<Bit53>
    {
        public ulong Value;
        public Bit53 (ulong  x) => Value = x;

        public bool Equals(Bit53 other) => Value == other.Value;
        public override bool Equals(object obj) => obj is Bit53 other && Equals(other);
        public override int GetHashCode() => Value.GetHashCode();
        public static bool operator ==(Bit53 x, Bit53 y) => x.Value == y.Value;
        public static bool operator !=(Bit53 x, Bit53 y) => x.Value != y.Value;

        public static implicit operator Bit53(ulong x) => new Bit53(x);
        public static implicit operator ulong(Bit53 x) => x.Value;

        public override string ToString() => Value.ToString();
    }
    public struct Bit54 : IEquatable<Bit54>
    {
        public ulong Value;
        public Bit54 (ulong  x) => Value = x;

        public bool Equals(Bit54 other) => Value == other.Value;
        public override bool Equals(object obj) => obj is Bit54 other && Equals(other);
        public override int GetHashCode() => Value.GetHashCode();
        public static bool operator ==(Bit54 x, Bit54 y) => x.Value == y.Value;
        public static bool operator !=(Bit54 x, Bit54 y) => x.Value != y.Value;

        public static implicit operator Bit54(ulong x) => new Bit54(x);
        public static implicit operator ulong(Bit54 x) => x.Value;

        public override string ToString() => Value.ToString();
    }
    public struct Bit55 : IEquatable<Bit55>
    {
        public ulong Value;
        public Bit55 (ulong  x) => Value = x;

        public bool Equals(Bit55 other) => Value == other.Value;
        public override bool Equals(object obj) => obj is Bit55 other && Equals(other);
        public override int GetHashCode() => Value.GetHashCode();
        public static bool operator ==(Bit55 x, Bit55 y) => x.Value == y.Value;
        public static bool operator !=(Bit55 x, Bit55 y) => x.Value != y.Value;

        public static implicit operator Bit55(ulong x) => new Bit55(x);
        public static implicit operator ulong(Bit55 x) => x.Value;

        public override string ToString() => Value.ToString();
    }
    public struct Bit56 : IEquatable<Bit56>
    {
        public ulong Value;
        public Bit56 (ulong  x) => Value = x;

        public bool Equals(Bit56 other) => Value == other.Value;
        public override bool Equals(object obj) => obj is Bit56 other && Equals(other);
        public override int GetHashCode() => Value.GetHashCode();
        public static bool operator ==(Bit56 x, Bit56 y) => x.Value == y.Value;
        public static bool operator !=(Bit56 x, Bit56 y) => x.Value != y.Value;

        public static implicit operator Bit56(ulong x) => new Bit56(x);
        public static implicit operator ulong(Bit56 x) => x.Value;

        public override string ToString() => Value.ToString();
    }
    public struct Bit57 : IEquatable<Bit57>
    {
        public ulong Value;
        public Bit57 (ulong  x) => Value = x;

        public bool Equals(Bit57 other) => Value == other.Value;
        public override bool Equals(object obj) => obj is Bit57 other && Equals(other);
        public override int GetHashCode() => Value.GetHashCode();
        public static bool operator ==(Bit57 x, Bit57 y) => x.Value == y.Value;
        public static bool operator !=(Bit57 x, Bit57 y) => x.Value != y.Value;

        public static implicit operator Bit57(ulong x) => new Bit57(x);
        public static implicit operator ulong(Bit57 x) => x.Value;

        public override string ToString() => Value.ToString();
    }
    public struct Bit58 : IEquatable<Bit58>
    {
        public ulong Value;
        public Bit58 (ulong  x) => Value = x;

        public bool Equals(Bit58 other) => Value == other.Value;
        public override bool Equals(object obj) => obj is Bit58 other && Equals(other);
        public override int GetHashCode() => Value.GetHashCode();
        public static bool operator ==(Bit58 x, Bit58 y) => x.Value == y.Value;
        public static bool operator !=(Bit58 x, Bit58 y) => x.Value != y.Value;

        public static implicit operator Bit58(ulong x) => new Bit58(x);
        public static implicit operator ulong(Bit58 x) => x.Value;

        public override string ToString() => Value.ToString();
    }
    public struct Bit59 : IEquatable<Bit59>
    {
        public ulong Value;
        public Bit59 (ulong  x) => Value = x;

        public bool Equals(Bit59 other) => Value == other.Value;
        public override bool Equals(object obj) => obj is Bit59 other && Equals(other);
        public override int GetHashCode() => Value.GetHashCode();
        public static bool operator ==(Bit59 x, Bit59 y) => x.Value == y.Value;
        public static bool operator !=(Bit59 x, Bit59 y) => x.Value != y.Value;

        public static implicit operator Bit59(ulong x) => new Bit59(x);
        public static implicit operator ulong(Bit59 x) => x.Value;

        public override string ToString() => Value.ToString();
    }
    public struct Bit60 : IEquatable<Bit60>
    {
        public ulong Value;
        public Bit60 (ulong  x) => Value = x;

        public bool Equals(Bit60 other) => Value == other.Value;
        public override bool Equals(object obj) => obj is Bit60 other && Equals(other);
        public override int GetHashCode() => Value.GetHashCode();
        public static bool operator ==(Bit60 x, Bit60 y) => x.Value == y.Value;
        public static bool operator !=(Bit60 x, Bit60 y) => x.Value != y.Value;

        public static implicit operator Bit60(ulong x) => new Bit60(x);
        public static implicit operator ulong(Bit60 x) => x.Value;

        public override string ToString() => Value.ToString();
    }
    public struct Bit61 : IEquatable<Bit61>
    {
        public ulong Value;
        public Bit61 (ulong  x) => Value = x;

        public bool Equals(Bit61 other) => Value == other.Value;
        public override bool Equals(object obj) => obj is Bit61 other && Equals(other);
        public override int GetHashCode() => Value.GetHashCode();
        public static bool operator ==(Bit61 x, Bit61 y) => x.Value == y.Value;
        public static bool operator !=(Bit61 x, Bit61 y) => x.Value != y.Value;

        public static implicit operator Bit61(ulong x) => new Bit61(x);
        public static implicit operator ulong(Bit61 x) => x.Value;

        public override string ToString() => Value.ToString();
    }
    public struct Bit62 : IEquatable<Bit62>
    {
        public ulong Value;
        public Bit62 (ulong  x) => Value = x;

        public bool Equals(Bit62 other) => Value == other.Value;
        public override bool Equals(object obj) => obj is Bit62 other && Equals(other);
        public override int GetHashCode() => Value.GetHashCode();
        public static bool operator ==(Bit62 x, Bit62 y) => x.Value == y.Value;
        public static bool operator !=(Bit62 x, Bit62 y) => x.Value != y.Value;

        public static implicit operator Bit62(ulong x) => new Bit62(x);
        public static implicit operator ulong(Bit62 x) => x.Value;

        public override string ToString() => Value.ToString();
    }
    public struct Bit63 : IEquatable<Bit63>
    {
        public ulong Value;
        public Bit63 (ulong  x) => Value = x;

        public bool Equals(Bit63 other) => Value == other.Value;
        public override bool Equals(object obj) => obj is Bit63 other && Equals(other);
        public override int GetHashCode() => Value.GetHashCode();
        public static bool operator ==(Bit63 x, Bit63 y) => x.Value == y.Value;
        public static bool operator !=(Bit63 x, Bit63 y) => x.Value != y.Value;

        public static implicit operator Bit63(ulong x) => new Bit63(x);
        public static implicit operator ulong(Bit63 x) => x.Value;

        public override string ToString() => Value.ToString();
    }
    public struct Bit64 : IEquatable<Bit64>
    {
        public ulong Value;
        public Bit64 (ulong  x) => Value = x;

        public bool Equals(Bit64 other) => Value == other.Value;
        public override bool Equals(object obj) => obj is Bit64 other && Equals(other);
        public override int GetHashCode() => Value.GetHashCode();
        public static bool operator ==(Bit64 x, Bit64 y) => x.Value == y.Value;
        public static bool operator !=(Bit64 x, Bit64 y) => x.Value != y.Value;

        public static implicit operator Bit64(ulong x) => new Bit64(x);
        public static implicit operator ulong(Bit64 x) => x.Value;

        public override string ToString() => Value.ToString();
    }
}
