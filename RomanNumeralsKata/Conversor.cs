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
            {1000, Roman_1000},
            {900, Roman_900},
            {500, Roman_500},
            {400, Roman_400},
            {100, Roman_100},
            {90, Roman_90},
            {50, Roman_50},
            {40, Roman_40},
            {10, Roman_10},
            {9, Roman_9},
            {5, Roman_5},
            {4, Roman_4},
            {1, Roman_1},
        };

        public static string Convert(int number)
        {
            var romanNumber = "";
            int remainToConvert = number;

            foreach (int arabicNumber in romanNumeralDictionary.Keys)
            {
                //Does the job if numberOfRepetitions > 0 ? 
                int numberOfRepetitions = remainToConvert / arabicNumber;

                // if remainToConvert = 0 break
                remainToConvert -= arabicNumber * numberOfRepetitions;


                // construct romanNumber
                for (var i = 0; i < numberOfRepetitions; i++)
                {
                    romanNumber += romanNumeralDictionary[arabicNumber];
                }
            }

            return romanNumber;
        }

     
        private static string Concatenation(int number, string romanNumber, string iterable)
        {
           
            return romanNumber;
        }
    }
}
