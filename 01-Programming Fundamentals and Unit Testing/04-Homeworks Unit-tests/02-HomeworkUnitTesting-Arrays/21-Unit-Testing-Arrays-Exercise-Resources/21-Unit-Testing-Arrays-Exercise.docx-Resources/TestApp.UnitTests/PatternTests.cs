using NUnit.Framework;

using System;

namespace TestApp.UnitTests;

public class PatternTests
{
    [Test]
    public void Test_SortInPattern_SortsIntArrayInPattern_SortsCorrectly()
    {
        // Arrange
        int[] nums = new int[] { 1, 2, 1, 5, 6 };
        int[] expected = new int[] { 1, 6, 2, 5 };
        // Act
        int[] actual = Pattern.SortInPattern(nums);

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test_SortInPattern_EmptyArray_ReturnsEmptyArray()
    {
        // Arrange
        int[] empty = Array.Empty<int>();

        // Act
        int[] actual = Pattern.SortInPattern(empty);

        // Assert
        Assert.That(actual, Is.Empty);
    }

    [Test]
    public void Test_SortInPattern_SingleElementArray_ReturnsSameArray()
    {
        // Arrange
        int[] singleElement = new int[] { 12 };
        int[] expected = new int[] { 12 };
        // Act
        int[] actual = Pattern.SortInPattern(singleElement);

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }
}
