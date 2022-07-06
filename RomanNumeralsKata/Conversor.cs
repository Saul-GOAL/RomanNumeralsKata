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
            if (number >= 50)
            {
                int result = number / 50;
                romanNumber = Concatenation(result, romanNumber, "L"); ;
                number -= 50 * result;
            }
            
            if (number >=40)
            {
                romanNumber += "XL";
                number -= 40;
            }
            if (number >= 10)
            {
                int result = number / 10;
                romanNumber = Concatenation(result, romanNumber, "X"); ;
                number -= 10*result;
            }

            if (number == 9)
                return romanNumber + "IX";
            
            if (number >= 5)
            {
                romanNumber += "V";
                number -= 5;
            }

            if (number == 4)
                return romanNumber + "IV";

        return Concatenation(number, romanNumber);

        }


        private static string Concatenation(int number, string romanNumber,string iterable = "I")
        {
            for (var i = 0; i < number; i++)
            {
                romanNumber += iterable;
            }
            return romanNumber;
        }
    }
}
