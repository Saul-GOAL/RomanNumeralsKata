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

            if (number >= 1000)
            {
                int result = number / 1000;
                romanNumber = Concatenation(result, romanNumber, "M"); ;
                number -= 1000 * result;
            }

            if (number >= 900)
            {
                romanNumber += "CM";
                number -= 900;
            }

            if (number >= 500)
            {
                romanNumber += "D";
                number -= 500;
            }

            if (number >= 400)
            {
                romanNumber += "CD";
                number -= 400;
            }

            if (number >= 100)
            {
                int result = number / 100;
                romanNumber = Concatenation(result, romanNumber, "C"); ;
                number -= 100 * result;
            }

            if (number >= 90)
            {
                romanNumber += "XC";
                number -= 90;
            }

            if (number >= 50)
            {
                romanNumber += "L";
                number -= 50;
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
