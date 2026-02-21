using NUnit.Framework;

using System;

namespace TestApp.UnitTests;

public class DuplicatesTests
{

    [Test]
    public void Test_RemoveDuplicates_EmptyArray_ReturnsEmptyArray()
    {
        // Arrange
        int[] numbers = Array.Empty<int>();

        // Act
        int[] actual = Duplicates.RemoveDuplicates(numbers);

        // Assert
        Assert.That(actual, Is.Empty);
    }

    [Test]
    public void Test_RemoveDuplicates_NoDuplicates_ReturnsOriginalArray()
    {
        // Arrange
        int[] numNoDuplicates = new int[] { 1, 2, 3 };
        int[] expected = new int[] { 1,2, 3 };

        // Act
        int[] actual = Duplicates.RemoveDuplicates(numNoDuplicates);

        // Assert
        Assert.That(actual, Is.EqualTo(numNoDuplicates));
    }

    [Test]
    public void Test_RemoveDuplicates_SomeDuplicates_ReturnsUniqueArray()
    {
        // Arrange
        int[] someDuplicates = new int[] { 1, 2, 2, 3 };
        int[] expected = new int[] { 1, 2, 3 };

        // Act
        int[] actual = Duplicates.RemoveDuplicates(someDuplicates);

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test_RemoveDuplicates_AllDuplicates_ReturnsSingleElementArray()
    {
        // Arrange
        int[] allDuplicates = new int[] { 1, 1, 1, 1 };
        int[] expected = new int[] { 1 };

        // Act
        int[] actual = Duplicates.RemoveDuplicates(allDuplicates);

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }
}
