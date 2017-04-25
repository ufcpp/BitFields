using BitFields;
using System;

namespace ConsoleApp1.BitFields
{
    class Program
    {
        public static void Run()
        {
            var v = new DoubleView();

            v.Sign = 1; // -
            v.Exponent = 3 + 1023; // 2^3
            v.Fraction = 0xE_0000_0000_0000; // 1.111b

            Console.WriteLine(v.AsDouble()); // -15

            Bit3 x = 1;
            x = 4;
            x = 10;
        }

        Bit2 x = 1;
        Bit2 y = 4;

        Bit1 X { get; } = 1;
        Bit1 Y { get; } = 2;

        void A()
        {
            A(1);
            A(2);
        }
        void A(Bit1 x) { }
        Bit1 F() => 2;
        Bit1 Z => 2;
    }
}
