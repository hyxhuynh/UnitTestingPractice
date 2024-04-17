using System;
using Xunit;

namespace UnitTestingExercise.Tests
{
    public class CalculatorTest
    {
        [Theory]
        [InlineData(2, 3, 5, 10)]
        [InlineData(1, 2, 3, 6)]
        [InlineData(5, 5, 2, 12)]
        [InlineData(-4, 2, 2, 0)]
        public void AddTest(int num1, int num2, int num3, int expected)
        {
            //Start Step 3 here:

            //Arrange
            // create a Calculator object
            Calculator calculatorTest = new Calculator();

            //Act
                // call the Add method that is located in the Calculator class
                // and store its result in a variable named actual
                int actual = calculatorTest.Add(num1, num2, num3);

            //Assert
                Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(10, 8, 2)]
        [InlineData(-5, 2, -7)]
        [InlineData(3, 2, 1)]
        [InlineData(6, 6, 0)]
        public void SubtractTest(int num1, int num2, int expected)
        {
            //Start Step 5 here:

            //Arrange
            Calculator calculatorTest = new Calculator();

            //Act
            int actual = calculatorTest.Subtract(num1, num2);

            //Assert
            Assert.Equal(expected, actual);

        }

        [Theory]
        [InlineData(2, 5, 10)]
        [InlineData(3, -5, -15)]
        [InlineData(7, 2, 14)]
        [InlineData(6, 8, 48)]
        public void MultiplyTest(int num1, int num2, int expected)
        {
            //Start Step 7 here:
            //Arrange
            Calculator calculatorTest = new Calculator();

            //Act
            int actual = calculatorTest.Multiply(num1, num2);

            //Assert
            Assert.Equal(expected, actual);

        }

        [Theory]
        [InlineData(10, 5, 2)]
        [InlineData(9, 3, 3)]
        [InlineData(60, 12, 5)]

        public void DivideTest(int num1, int num2, int expected)
        {
            //Arrange
            Calculator calculatorTest = new Calculator();
            //Act
            int actual = calculatorTest.Divide(num1, num2);

            //Assert
            Assert.Equal(expected, actual);
        }

    }
}
