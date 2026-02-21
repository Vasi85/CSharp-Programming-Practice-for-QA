using NUnit.Framework;

using System.Collections.Generic;

namespace TestApp.UnitTests;

public class MaxNumberTests
{

    [Test]
    public void Test_FindMax_InputHasOneElement_ShouldReturnTheElement()
    {
        // Arrange
        List<int> oneElement = new List<int>() { 18 };
        int expected = 18;
        // Act
        int result = MaxNumber.FindMax(oneElement);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_FindMax_InputHasPositiveIntegers_ShouldReturnMaximum()
    {
        // Arrange
        List<int> positiveElements = new List<int>() { 5, 12, 18 };
        int expected = 18;
        // Act
        int result = MaxNumber.FindMax(positiveElements);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_FindMax_InputHasNegativeIntegers_ShouldReturnMaximum()
    {
        // Arrange
        List<int> negativeElements = new List<int>() { -5, -12, -18 };
        int expected = -5;
        // Act
        int result = MaxNumber.FindMax(negativeElements);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_FindMax_InputHasMixedIntegers_ShouldReturnMaximum()
    {
        // Arrange
        List<int> mixedElement = new List<int>() { -5, 7, 11, -12, 15, -18 };
        int expected = 15;
        // Act
        int result = MaxNumber.FindMax(mixedElement);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_FindMax_InputHasDuplicateMaxValue_ShouldReturnMaximum()
    {
        // Arrange
        List<int> duplicateMaxValue = new List<int>() { 15, -5, 7, 11, -12, 15, -18 };
        int expected = 15;
        // Act
        int result = MaxNumber.FindMax(duplicateMaxValue);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }
}
