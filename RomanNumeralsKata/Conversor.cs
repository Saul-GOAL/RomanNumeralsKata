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

            for (var i = 0; i < number; i++)
            {
                romanNumber += "I";
            }
            return romanNumber;
        }
    }
}
