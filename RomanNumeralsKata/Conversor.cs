using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RomanNumerals
{
    public static class Conversor
    {
        private const string Roman_1000 = "M";
        private const string Roman_900 = "CM";
        private const string Roman_500 = "D";
        private const string Roman_400 = "CD";
        private const string Roman_100 = "C";
        private const string Roman_90 = "XC";
        private const string Roman_50 = "L";
        private const string Roma_40 = "XL";
        private const string Roman_10 = "X";
        private const string Roman_9 = "IX";
        private const string Roman_5 = "V";
        private const string Roman_4 = "IV";
        private const string Roman_1 = "I";

        public static string Convert(int number)
        {
            var romanNumber = "";

            if (number >= 1000)
            {
                int result = number / 1000;
                romanNumber = Concatenation(result, romanNumber, Roman_1000); ;
                number -= 1000 * result;
            }

            if (number >= 900)
            {
                romanNumber += Roman_900;
                number -= 900;
            }

            if (number >= 500)
            {
                romanNumber += Roman_500;
                number -= 500;
            }

            if (number >= 400)
            {
                romanNumber += Roman_400;
                number -= 400;
            }

            if (number >= 100)
            {
                int result = number / 100;
                romanNumber = Concatenation(result, romanNumber, Roman_100); ;
                number -= 100 * result;
            }

            if (number >= 90)
            {
                romanNumber += Roman_90;
                number -= 90;
            }

            if (number >= 50)
            {
                romanNumber += Roman_50;
                number -= 50;
            }
            
            if (number >=40)
            {
                romanNumber += Roma_40;
                number -= 40;
            }
            if (number >= 10)
            {
                int result = number / 10;
                romanNumber = Concatenation(result, romanNumber, Roman_10); ;
                number -= 10*result;
            }

            if (number == 9)
            {
                romanNumber += Roman_9;
                number -= 9;
            }
            
            if (number >= 5)
            {
                romanNumber += Roman_5;
                number -= 5;
            }

            if (number == 4)
            {
                romanNumber += Roman_4;
                number -= 4;
            }

        return Concatenation(number, romanNumber);

        }


        private static string Concatenation(int number, string romanNumber,string iterable = Roman_1)
        {
            for (var i = 0; i < number; i++)
            {
                romanNumber += iterable;
            }
            return romanNumber;
        }
    }
}
