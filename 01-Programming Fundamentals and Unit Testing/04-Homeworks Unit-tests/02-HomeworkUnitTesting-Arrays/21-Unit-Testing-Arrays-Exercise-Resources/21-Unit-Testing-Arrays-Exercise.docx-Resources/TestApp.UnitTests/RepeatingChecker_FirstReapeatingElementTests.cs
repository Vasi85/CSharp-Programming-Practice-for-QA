using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace TestApp.UnitTests;

public class RepeatingChecker_FirstReapeatingElementTests
{
    [Test]
    public void Test_FindFirstRepeatingElement_EmptyArray_ReturnsNegativeOne()
    {
        // Arrange
        int[] emptyArray = Array.Empty<int>();
        int expected = -1;

        // Act
        int actual = RepeatingChecker.FindFirstRepeatingElement(emptyArray);

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test_FindFirstRepeatingElement_ArrayWithOneInteger_ReturnsNegativeOne()
    {
        // Arrange
        int[] oneInt = new int[] { 5 };
        int expected = -1;

        // Act
        int actual = RepeatingChecker.FindFirstRepeatingElement(oneInt);

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test_FindFirstRepeatingElement_ArrayWithManyNonRepeatingValues_ReturnsNegativeOne()
    {
        // Arrange
        int[] manyValues = new int[] { 5, 7, 1, 3 };
        int expected = -1;

        // Act
        int actual = RepeatingChecker.FindFirstRepeatingElement(manyValues);

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test_FindFirstRepeatingElement_ArrayWithTwoReapeatingNegativeOneValue_ReturnsNegativeOne()
    {
        // Arrange
        int[] twoRepeatingValues = new int[] { -1, 3, 9, -1 };
        int expected = -1;

        // Act
        int actual = RepeatingChecker.FindFirstRepeatingElement(twoRepeatingValues);

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test_FindFirstRepeatingElement_ArrayWithManyIntegerWithSameValues_ReturnsTheIntegerValue()
    {
        // Arrange
        int[] manyRepeatingValues = new int[] { 5, 5, 5, 5 };
        int expected = 5;

        // Act
        int actual = RepeatingChecker.FindFirstRepeatingElement(manyRepeatingValues);

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test_FindFirstRepeatingElement_ArrayWithAtLeastTwoReaptingValues_ReturnsTheRepeatingValue()
    {
        // Arrange
        int[] manyRepeatingValues = new int[] { 5, 7, 12, 15, 5 };
        int expected = 5;

        // Act
        int actual = RepeatingChecker.FindFirstRepeatingElement(manyRepeatingValues);

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }
}
