using System;
using System.Collections.Generic;
using System.Text;

namespace Laba_4avl
{
    public class RomanNumberException : Exception
    {
        public override string Message
        {
            get
            {
                return "number must be greater than 0";
            }
        }
    }
}