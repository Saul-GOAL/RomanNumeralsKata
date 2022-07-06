using RomanNumerals;

namespace RomanNumeralsTest 
{
    public class Tests
    {
        //Write a method "string convert(int)" that takes a number and converts it to the according String representation.


        [TestCase(1,"I")]
        [TestCase(2, "II")]
        [TestCase(3, "III")]
        [TestCase(5, "V")]
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
        public void Given_A_Special_Integer_It_Will_Return_The_String_Roman_Numeral_Correspondent(int testElement, string expectedResult)
        {
            //Arrange

            //Act
            string romanNumeral = Conversor.Convert(testElement);

            //Assert
            Assert.That(romanNumeral, Is.EqualTo(expectedResult));
        }

        [TestCase(14, "XIV")]
        [TestCase(15, "XV")]
        [TestCase(16, "XVI")]
        [TestCase(19, "XIX")]
        public void Given_A_Special_Integer_It_Will_Return_The_String_Compound_Roman_Numeral_Correspondent(int testElement, string expectedResult)
        {
            //Arrange

            //Act
            string romanNumeral = Conversor.Convert(testElement);

            //Assert
            Assert.That(romanNumeral, Is.EqualTo(expectedResult));
        }

    }
}