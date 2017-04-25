using System;
using System.Collections.Generic;
using System.Text;

namespace TypeClassBits
{
    public interface ILogicalOperator<T>
    {
        T One { get; }
        T As(ulong value);
        T Not(T value);
        void And(ref T x, T y);
        void Or(ref T x, T y);
        void LeftShift(ref T x, int i);
        void RightShift(ref T x, int i);
        bool IsZero(T x);
    }
}
