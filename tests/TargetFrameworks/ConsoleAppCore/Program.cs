using System;

namespace ConsoleAppCore
{
    partial struct Flags
    {
        enum BitFields { A = 1, B = 1, C = 1 }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}