using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace TestApp.UnitTests;

public class MajorityTests
{
    [Test]
    public void Test_IsEvenOrOddMajority_EmpryArray_ReturnsZero()
    {
        // Arrange
        int[] emptyArray = Array.Empty<int>();
        int expected = 0;

        // Act
        int actual = Majority.IsEvenOrOddMajority(emptyArray);

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test_IsEvenOrOddMajority_ArrayOnlyWithZeros_ReturnsZero()
    {
        // Arrange
        int[] zeroArray = new int[] { 0, 0, 0 };
        int expected = 0;

        // Act
        int actual = Majority.IsEvenOrOddMajority(zeroArray);

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test_IsEvenOrOddMajority_EqualOddAndEvenNumbers_ReturnsZero()
    {
        // Arrange
        int[] equalOddAndEvenNums = new int[] { 1, 3, 5, 2, 4, 6 };
        int expected = 0;

        // Act
        int actual = Majority.IsEvenOrOddMajority(equalOddAndEvenNums);

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test_IsEvenOrOddMajority_EvenMajority_ReturnsPositiveNumber()
    {
        // Arrange
        int[] EvenNums = new int[] { 1, 3, 2, 4, 6 };
        int expected = 0;

        // Act
        int actual = Majority.IsEvenOrOddMajority(EvenNums);

        // Assert
        Assert.That(actual, Is.Positive);
    }

    [Test]
    public void Test_IsEvenOrOddMajority_OddMajority_ReturnsNegativeNumber()
    {
        // Arrange
        int[] equalOddAndEvenNums = new int[] { 1, 3, 5, 2, 4 };
        int expected = 0;

        // Act
        int actual = Majority.IsEvenOrOddMajority(equalOddAndEvenNums);

        // Assert
        Assert.That(actual, Is.Negative);
    }
}
