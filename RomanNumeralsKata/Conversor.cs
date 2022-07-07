using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RomanNumerals
{
    public class Conversor
    {
        private const string Roman_1000 = "M";
        private const string Roman_900 = "CM";
        private const string Roman_500 = "D";
        private const string Roman_400 = "CD";
        private const string Roman_100 = "C";
        private const string Roman_90 = "XC";
        private const string Roman_50 = "L";
        private const string Roman_40 = "XL";
        private const string Roman_10 = "X";
        private const string Roman_9 = "IX";
        private const string Roman_5 = "V";
        private const string Roman_4 = "IV";
        private const string Roman_1 = "I";

        private static Dictionary<int, string> romanNumeralDictionary = new Dictionary<int, string>
        {
            {1, Roman_1},
            {4, Roman_4},
            {5, Roman_5},
            {9, Roman_9},
            {10, Roman_10},
            {40, Roman_40},
            {50, Roman_50},
            {90, Roman_90},
            {100, Roman_100},
            {400, Roman_400},
            {500, Roman_500},
            {900, Roman_900},
            {1000, Roman_1000},
        };

        public static string Convert(int number)
        {
            var romanNumber = "";

            if (number >= 1000)
            {
                number = ConvertNumberToRomanNumber(number, ref romanNumber, 1000);
            }

            if (number >= 900)
            {
                number = ConvertNumberToRomanNumber(number, ref romanNumber, 900);
            }

            if (number >= 500)
            {
                number = ConvertNumberToRomanNumber(number, ref romanNumber, 500);
            }

            if (number >= 400)
            {
                number = ConvertNumberToRomanNumber(number, ref romanNumber, 400);
            }

            if (number >= 100)
            {
                number = ConvertNumberToRomanNumber(number, ref romanNumber, 100);
            }

            if (number >= 90)
            {
                number = ConvertNumberToRomanNumber(number, ref romanNumber, 90);
            }

            if (number >= 50)
            {
                number = ConvertNumberToRomanNumber(number, ref romanNumber, 50);
            }

            if (number >= 40)
            {
                number = ConvertNumberToRomanNumber(number, ref romanNumber, 40);
            }

            if (number >= 10)
            {
                number = ConvertNumberToRomanNumber(number, ref romanNumber, 10);
            }

            if (number == 9)
            {
            number = ConvertNumberToRomanNumber(number, ref romanNumber, 9);
            }

            if (number >= 5)
            {
                number = ConvertNumberToRomanNumber(number, ref romanNumber, 5);
            }

            if (number == 4)
            {
                number = ConvertNumberToRomanNumber(number, ref romanNumber, 4);
            }
            
            number = ConvertNumberToRomanNumber(number, ref romanNumber, 1);

            return romanNumber;
        }

        private static int ConvertNumberToRomanNumber(int number, ref string romanNumber, int arabicNumber)
        {
            int numberOfRepetitions = number / arabicNumber;
            romanNumber = Concatenation(numberOfRepetitions, romanNumber, romanNumeralDictionary[arabicNumber]);
            number -= arabicNumber * numberOfRepetitions;
            return number;
        }
        private static string Concatenation(int number, string romanNumber, string iterable)
        {
            for (var i = 0; i < number; i++)
            {
                romanNumber += iterable;
            }
            return romanNumber;
        }
    }
}
