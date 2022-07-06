using RomanNumerals;

namespace RomanNumeralsTest 
{
    public class Tests
    {
        //Write a method "string convert(int)" that takes a number and converts it to the according String representation.

        [Test]
        public void Given_The_Integer_1_It_Will_Return_The_String_I()
        {
            //Arrange
            int testElement = 1;
            string expectedResult = "I";

            //Act
            string romanNumeral = Conversor.Convert(testElement);

            //Assert
            Assert.That(romanNumeral, Is.EqualTo(expectedResult));
        }

        [Test]
        public void Given_The_Integer_2_It_Will_Return_The_String_II()
        {
            //Arrange
            int testElement = 2;
            string expectedResult = "II";

            //Act
            string romanNumeral = Conversor.Convert(testElement);

            //Assert
            Assert.That(romanNumeral, Is.EqualTo(expectedResult));
        }

        [Test]
        public void Given_The_Integer_3_It_Will_Return_The_String_III()
        {
            //Arrange
            int testElement = 3;
            string expectedResult = "III";

            //Act
            string romanNumeral = Conversor.Convert(testElement);

            //Assert
            Assert.That(romanNumeral, Is.EqualTo(expectedResult));
        }
    }
}