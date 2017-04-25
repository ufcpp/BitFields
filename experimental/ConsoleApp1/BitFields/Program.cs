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
        }
    }
}
