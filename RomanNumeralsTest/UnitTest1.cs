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
        [TestCase(7, "VII")]
        [TestCase(8, "VIII")]
        [TestCase(10, "X")]
        [TestCase(11, "XI")]
        [TestCase(12, "XII")]
        [TestCase(13, "XIII")]
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
        public void Given_A_Special_Integer_4_Or_9_It_Will_Return_The_String_Roman_Numeral_Correspondent(int testElement, string expectedResult)
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
        public void Given_A_Special_Integer_5_It_Will_Return_The_String_Compound_Roman_Numeral_Correspondent(int testElement, string expectedResult)
        {
            //Arrange

            //Act
            string romanNumeral = Conversor.Convert(testElement);

            //Assert
            Assert.That(romanNumeral, Is.EqualTo(expectedResult));
        }

        [TestCase(40, "XL")]
        [TestCase(42, "XLII")]
        [TestCase(45, "XLV")]
        public void Test_case_Given_number_40_return_XL(int testElement, string expectedResult)
        {
            //Arrange

            //Act
            string romanNumeral = Conversor.Convert(testElement);

            //Assert
            Assert.That(romanNumeral, Is.EqualTo(expectedResult));
        }
        [TestCase(50, "L")]
        [TestCase(52, "LII")]
        [TestCase(55, "LV")]
        [TestCase(60, "LX")]
        public void Test_case_Given_number_50_return_L(int testElement, string expectedResult)
        {
            //Arrange

            //Act
            string romanNumeral = Conversor.Convert(testElement);

            //Assert
            Assert.That(romanNumeral, Is.EqualTo(expectedResult));
        }
    }
}