using NUnit.Framework;

using System;

namespace TestApp.UnitTests;

public class EvenOddSubtractionTests
{
    [Test]
    public void Test_FindDifference_InputIsEmpty_ShouldReturnZero()
    {
        // Arrange
        int[] emptyArray = Array.Empty<int>();

        // Act
        int result = EvenOddSubtraction.FindDifference(emptyArray);

        // Assert
        Assert.That(result, Is.EqualTo(0));
    }

    // TODO: finish the test
    [Test]
    public void Test_FindDifference_InputHasOnlyEvenNumbers_ShouldReturnEvenSum()
    {
        // Arrange
        int[] onlyEvenNumbers = new int[] { 2, 4, 6, 8 };
        int expected = 20;

        // Act
        int result = EvenOddSubtraction.FindDifference(onlyEvenNumbers);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_FindDifference_InputHasOnlyOddNumbers_ShouldReturnNegativeOddSum()
    {
        // Arrange
        int[] onlyOddNumbers = new int[] { 1, 3, 5, 7 };
        int expected = -16;

        // Act
        int result = EvenOddSubtraction.FindDifference(onlyOddNumbers);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_FindDifference_InputHasMixedNumbers_ShouldReturnDifference()
    {
        int[] mixedNumbers = new int[] { 1, 2, 3, 4 };
        int expected = 2;

        // Act
        int result = EvenOddSubtraction.FindDifference(mixedNumbers);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }
}
