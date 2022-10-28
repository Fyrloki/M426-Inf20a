using System;
using Xunit;

namespace Calculator.Tests
{
    public class CalculatorTest
    {
        [Fact]
        public void TestAddThreeToTwoPIsFive()
        {
            // Arrange
            int a = 2;
            int b = 3;
            int expected = 5;
            Calculator calculator = new Calculator();

            // Act
            int actual = calculator.Add(a, b);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestSubtractFourFromSixIsTwo()
        {
            // Given
            int a = 6;
            int b = 4;
            int expected = 2;
            Calculator calculator = new Calculator();

            // When
            int actual = calculator.Subtract(a, b);

            // Then
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void SimpleMultiplication_TestMultiply_True()
        {
            //Arrange
            int factorOne = 2;
            int factorTwo = 3;
            int expected = factorOne * factorTwo;
            Calculator calculator = new Calculator();

            //Act
            int actual = calculator.Multiply(factorOne, factorTwo);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void SimpleDivide_TestDivide_True()
        {
            //Arrange
            int dividend = 4;
            int divisor = 2;
            float expected = dividend / divisor;
            Calculator calculator = new Calculator();

            //Act
            float actual = calculator.Divide(dividend, divisor);

            //Assert
            Assert.Equal(expected, actual);
        }


        //Ich mache es sicherlich nicht wie in Aufgabe 3.3 beschrieben ist.
        //Die Exceptions die geworfen werden, sollten immer möglichst genau sein.
        //ArgumentEx ist viel zu allgemein.
        [Fact]
        public void DivideByZero_TestDivide_Exception()
        {
            //Arrange
            int dividend = 4;
            int divisor = 0;
            Calculator calculator = new Calculator();

            //Act & Assert
            Assert.Throws<DivideByZeroException>(() => calculator.Divide(dividend, divisor));
        }
    }
}
