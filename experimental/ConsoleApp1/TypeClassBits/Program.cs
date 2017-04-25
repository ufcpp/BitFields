using System;

namespace ConsoleApp1.TypeClassBits
{
    class Program
    {
        public static void Run()
        {
            var v = new DoubleView();

            var (f, e, s) = v;
            s.Value = 1; // -
            e.Value = 3 + 1023; // 2^3
            f.Value = 0xE_0000_0000_0000; // 1.111b

            Console.WriteLine(v.AsDouble()); // -15
        }
    }
}
