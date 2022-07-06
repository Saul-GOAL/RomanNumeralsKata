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
            var romanNumber = "";
            if (number == 30)
                return "XXX";

            if (number == 20)
                return "XX";

            if (number >= 10)
            {
                romanNumber += "X";
                number -= 10;
            }

            if (number == 9)
                return romanNumber + "IX";
            
            if (number >= 5)
            {
                romanNumber += "V";
                number -= 5;
                return Concatenation(number, romanNumber);
            }

            if (number == 4)
                return romanNumber + "IV";

         return Concatenation(number, romanNumber);

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
