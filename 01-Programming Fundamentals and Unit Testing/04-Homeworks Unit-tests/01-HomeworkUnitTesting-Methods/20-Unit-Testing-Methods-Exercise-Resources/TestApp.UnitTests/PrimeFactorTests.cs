using NUnit.Framework;

namespace TestApp.UnitTests;

public class PrimeFactorTests
{
    [Test]
    public void Test_FindLargestPrimeFactor_PrimeNumber()
    {
        // Arrange
        long primeNumber = 5;
        long expected = 5;

        // Act
        long result = PrimeFactor.FindLargestPrimeFactor(primeNumber);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_FindLargestPrimeFactor_LargeNumber()
    {
        // Arrange
        long largeNumber = 35;
        long expected = 7;

        // Act
        long result = PrimeFactor.FindLargestPrimeFactor(largeNumber);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }
}
