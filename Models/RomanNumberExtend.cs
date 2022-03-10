using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba_4avl
{
    internal class RomanNumberExtend : RomanNumber
    {
        public RomanNumberExtend(string number) : base((ushort)RomanToInt(number)) { }

    }

}