using NUnit.Framework;

namespace TestApp.UnitTests;

public class FibonacciTests
{
    [Test]
    public void Test_CalculateFibonacci_ZeroInput()
    {
        // Arrange
        int num = 0;

        // Act
        int result = Fibonacci.CalculateFibonacci(num);

        // Assert
        Assert.AreEqual(0, result);
    }

    [Test]
    public void Test_CalculateFibonacci_PositiveInput()
    {
        // Arrange
        int num = 5;
        int expected = 5;

        // Act
        int result = Fibonacci.CalculateFibonacci(num);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }
}