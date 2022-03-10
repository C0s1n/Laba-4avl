using Laba_4avl;

namespace Laba_4avl.ViewModels
{
    internal class Calculator
    {
        static public string Calc(string number1, string number2, string command)
        {
            if (command == "+") return ((new RomanNumberExtend(number1) + new RomanNumberExtend(number2)).ToString());
            if (command == "-") return ((new RomanNumberExtend(number1) - new RomanNumberExtend(number2)).ToString());
            if (command == "*") return ((new RomanNumberExtend(number1) * new RomanNumberExtend(number2)).ToString());
            return (new RomanNumberExtend(number1) / new RomanNumberExtend(number2)).ToString();

        }
    }
}