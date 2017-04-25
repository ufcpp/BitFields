using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace TypeClassBits
{
    public unsafe struct Bits<T, TOp, LowBit, HighBit> : IEnumerable<bool>, IReadOnlyList<bool>
        where T : struct
        where TOp : ILogicalOperator<T>
        where LowBit : IConstant<int>
        where HighBit : IConstant<int>
    {
        private static int NumBits => default(HighBit).Value - default(LowBit).Value;

        // I want to use ByReferenct<T> if possible
        // https://github.com/dotnet/coreclr/blob/master/src/mscorlib/src/System/ByReference.cs
        private void* _ptr;
        public Bits(void* ptr) => _ptr = ptr;
        public Bits(ref T x) : this(Unsafe.AsPointer(ref x)) { }

        private ref T Reference => ref Unsafe.AsRef<T>(_ptr);

        private static readonly T ValueMask = default(TOp).As((1UL << default(HighBit).Value) - (1UL << default(LowBit).Value));
        private static readonly T NotValueMask = default(TOp).Not(ValueMask);

        public T Value
        {
            get
            {
                var r = Reference;
                default(TOp).And(ref r, ValueMask);
                default(TOp).RightShift(ref r, default(LowBit).Value);
                return r;
            }
            set
            {
                ref var r = ref Reference;
                default(TOp).And(ref r, NotValueMask);
                default(TOp).LeftShift(ref value, default(LowBit).Value);
                default(TOp).And(ref value, ValueMask);
                default(TOp).Or(ref r, value);
            }
        }

        const int BitShift = 3;
        const int BitMask = 0b111;

        private bool GetNthBit(int n)
        {
            CheckRange(n);
            var r = Reference;
            var mask = default(TOp).One;
            default(TOp).LeftShift(ref mask, n);
            default(TOp).And(ref r, mask);
            return !default(TOp).IsZero(r);
        }

        private void SetNthBit(int n, bool value)
        {
            CheckRange(n);

            ref var r = ref Reference;

            var mask = default(TOp).One;
            default(TOp).LeftShift(ref mask, n);

            if (value)
            {
                default(TOp).Or(ref r, mask);
            }
            else
            {
                mask = default(TOp).Not(mask);
                default(TOp).And(ref r, mask);
            }
        }

        private static void CheckRange(int i)
        {
            if (i < default(LowBit).Value) throw new IndexOutOfRangeException();
            else if (i >= default(HighBit).Value) throw new IndexOutOfRangeException();
        }

        public bool this[int index]
        {
            get => GetNthBit(index + default(LowBit).Value);
            set => SetNthBit(index + default(LowBit).Value, value);
        }

        public int Count => NumBits;

        public Enumerator GetEnumerator() => new Enumerator(this);
        IEnumerator<bool> IEnumerable<bool>.GetEnumerator() => GetEnumerator();
        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

        public struct Enumerator : IEnumerator<bool>
        {
            private int _i;
            private Bits<T, TOp, LowBit, HighBit> _bits;
            public Enumerator(Bits<T, TOp, LowBit, HighBit> bits) => (_bits, _i) = (bits, default(LowBit).Value - 1);

            public bool Current => _bits.GetNthBit(_i);
            object IEnumerator.Current => Current;
            public void Dispose() { }
            public bool MoveNext() => ++_i < default(HighBit).Value;
            public void Reset() => _i = -1;
        }
    }
}
