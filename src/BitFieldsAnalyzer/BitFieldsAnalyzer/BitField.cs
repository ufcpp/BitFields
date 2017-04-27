using Microsoft.CodeAnalysis.CSharp.Syntax;
using System.Collections.Generic;
using System.Linq;

namespace BitFieldsAnalyzer
{
    struct BitField
    {
        public string Name;
        public int StartBit;
        public int EndBit;

        public BitField(string name, int start, int end) => (Name, StartBit, EndBit) = (name, start, end);
        public void Deconstruct(out string name, out int start, out int end, out int bits) => (name, start, end, bits) = (Name, StartBit, EndBit, Bits);

        public static IEnumerable<BitField> Create(IEnumerable<(string name, int bits)> items)
        {
            var start = 0;
            foreach (var (name, bits) in items)
            {
                var end = start + bits;
                yield return new BitField(name, start, end);
                start = end;
            }
        }
        public int Bits => EndBit - StartBit;
    }
}
