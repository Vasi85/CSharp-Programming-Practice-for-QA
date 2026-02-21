using NUnit.Framework;

namespace TestApp.UnitTests;

public class FactorialTests
{
    [Test]
    public void Test_CalculateFactorial_InputZero_ReturnsOne()
    {
        // Arrange
        int num = 0;
        int expected = 1;

        // Act
        int result = Factorial.CalculateFactorial(num);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_CalculateFactorial_InputPositiveNumber_ReturnsCorrectFactorial()
    {
        // Arrange
        int num = 4;
        int expected = 24;

        // Act
        int result = Factorial.CalculateFactorial(num);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }
}
