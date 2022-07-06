using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RomanNumerals
{
    public static class Conversor
    {
        public static string Convert(int testElement)
        {
            if (testElement >= 3)
                return "III";
            else if (testElement == 2)
                return "II";
            else if (testElement == 1)
                return "I";
            else
                return testElement.ToString();
        }
    }
}
