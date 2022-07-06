using RomanNumerals;

namespace RomanNumeralsTest 
{
    public class Tests
    {
        //Write a method "string convert(int)" that takes a number and converts it to the according String representation.


        [TestCase(1,"I")]
        [TestCase(2, "II")]
        [TestCase(3, "III")]
        public void Given_The_Integer_1_2_Or_3_It_Will_Return_The_String_I_II_Or_III_Respectively(int testElement, string expectedResult)
        {
            //Arrange

            //Act
            string romanNumeral = Conversor.Convert(testElement);

            //Assert
            Assert.That(romanNumeral, Is.EqualTo(expectedResult));
        }

        
    }
}