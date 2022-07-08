using RomanNumerals;

namespace RomanNumeralsTest 
{
    public class Tests
    {
        //Write a method "string convert(int)" that takes a number and converts it to the according String representation.


        [TestCase(1,"I")]
        [TestCase(2, "II")]
        [TestCase(3, "III")]
        [TestCase(6, "VI")]
        [TestCase(13, "XIII")]
        [TestCase(42, "XLII")]
        [TestCase(241, "CCXLI")]
        [TestCase(1111, "MCXI")]
        public void Given_One_Integer_It_Will_Return_The_String_Roman_Numeral_Correspondent(int testElement, string expectedResult)
        {
            //Arrange

            //Act
            string romanNumeral = Conversor.Convert(testElement);

            //Assert
            Assert.That(romanNumeral, Is.EqualTo(expectedResult));
        }


        [TestCase(4, "IV")]
        [TestCase(9, "IX")]
        [TestCase(14, "XIV")]
        [TestCase(19, "XIX")]
        [TestCase(29, "XXIX")]
        [TestCase(99, "XCIX")]
        [TestCase(944, "CMXLIV")]
        [TestCase(999, "CMXCIX")]
        [TestCase(2999, "MMCMXCIX")]
        public void Given_A_Special_Integer_4s_Or_9s_It_Will_Return_The_String_Roman_Numeral_Correspondent(int testElement, string expectedResult)
        {
            //Arrange

            //Act
            string romanNumeral = Conversor.Convert(testElement);

            //Assert
            Assert.That(romanNumeral, Is.EqualTo(expectedResult));
        }

        [TestCase(5, "V")]
        [TestCase(15, "XV")]
        [TestCase(20, "XX")]
        [TestCase(30, "XXX")]
        [TestCase(40, "XL")]
        [TestCase(45, "XLV")]
        [TestCase(65, "LXV")]
        [TestCase(95, "XCV")]
        [TestCase(100, "C")]
        [TestCase(450, "CDL")]
        [TestCase(555, "DLV")]
        [TestCase(600, "DC")]
        [TestCase(1000, "M")]
        [TestCase(1110, "MCX")]

        public void Given_A_Special_Integer_5s_Or_10s_It_Will_Return_The_String_Compound_Roman_Numeral_Correspondent(int testElement, string expectedResult)
        {
            //Arrange

            //Act
            string romanNumeral = Conversor.Convert(testElement);

            //Assert
            Assert.That(romanNumeral, Is.EqualTo(expectedResult));
        }

    }
}