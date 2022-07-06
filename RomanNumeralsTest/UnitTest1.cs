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
        public void Given_One_Integer_It_Will_Return_The_String_Roman_Numeral_Correspondent(int testElement, string expectedResult)
        {
            //Arrange

            //Act
            string romanNumeral = Conversor.Convert(testElement);

            //Assert
            Assert.That(romanNumeral, Is.EqualTo(expectedResult));
        }

        [Test]
        public void Given_The_Special_Integer_4_It_Will_Return_The_String_Roman_Numeral_Correspondent()
        {
            //Arrange
            int testElement = 4;
            string expectedResult = "IV";

            //Act
            string romanNumeral = Conversor.Convert(testElement);

            //Assert
            Assert.That(romanNumeral, Is.EqualTo(expectedResult));
        }
        [Test]
        public void Given_The_Special_Integer_9_It_Will_Return_The_String_Roman_Numeral_Correspondent()
        {
            //Arrange
            int testElement = 9;
            string expectedResult = "IX";

            //Act
            string romanNumeral = Conversor.Convert(testElement);

            //Assert
            Assert.That(romanNumeral, Is.EqualTo(expectedResult));
        }
        [Test]
        public void Given_The_Integer_10_It_Will_Return_The_String_Roman_Numeral_Correspondent()
        {
            //Arrange
            int testElement = 10;
            string expectedResult = "X";

            //Act
            string romanNumeral = Conversor.Convert(testElement);

            //Assert
            Assert.That(romanNumeral, Is.EqualTo(expectedResult));
        }
        [Test]
        public void Given_The_Integer_11_It_Will_Return_The_String_Roman_Numeral_Correspondent()
        {
            //Arrange
            int testElement = 11;
            string expectedResult = "XI";

            //Act
            string romanNumeral = Conversor.Convert(testElement);

            //Assert
            Assert.That(romanNumeral, Is.EqualTo(expectedResult));
        }
        [Test]
        public void Given_The_Integer_12_It_Will_Return_The_String_Roman_Numeral_Correspondent()
        {
            //Arrange
            int testElement = 12;
            string expectedResult = "XII";

            //Act
            string romanNumeral = Conversor.Convert(testElement);

            //Assert
            Assert.That(romanNumeral, Is.EqualTo(expectedResult));
        }
        [Test]
        public void Given_The_Integer_13_It_Will_Return_The_String_Roman_Numeral_Correspondent()
        {
            //Arrange
            int testElement = 13;
            string expectedResult = "XIII";

            //Act
            string romanNumeral = Conversor.Convert(testElement);

            //Assert
            Assert.That(romanNumeral, Is.EqualTo(expectedResult));
        }
       
    }
}