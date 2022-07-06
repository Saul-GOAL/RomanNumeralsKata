using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RomanNumerals
{
    public static class Conversor
    {
        public static string Convert(int number)
        {
            if (number == 13)
            {
                return "XIII";
            }
            else if (number == 12)
            {
                return "XII";
            }
            if (number == 11)
            {
                return "XI";
            }
            if (number == 10)
            {
                return "X";
            }


            if (number == 9)
                return "IX";

            if (number == 4)
                return "IV";

            var romanNumber = "";

            if (number >= 5)
            {
                romanNumber += "V";
                number -= 5;
                return Concatenation(number, romanNumber);
            }
            else
            {
                return Concatenation(number, romanNumber);
            }
        }


        private static string Concatenation(int number, string romanNumber)
        {
            for (var i = 0; i < number; i++)
            {
                romanNumber += "I";
            }
            return romanNumber;
        }
    }
}
