using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace TestApp.UnitTests;

public class PrimeNumberFinderTests
{
    [Test]
    public void Test_GetAllPrimeNumbers_InputArrayWithLessThanOrEqualToOneElementsOnly_ReturnsEmptyArray()
    {
        // Arrange
        int[] num = new int[] { 1, -1, 0 };
        int[] expected = Array.Empty<int>();

        // Act
        int[] result = PrimeNumberFinder.GetAllPrimeNumbers(num);

        // Assert
        CollectionAssert.AreEqual(expected, result);
    }

    [Test]
    public void Test_GetAllPrimeNumbers_InputArrayWithOnlyOneNonPrimeNumber_ReturnsEmptyArray()
    {
        // Arrange
        int[] onlyOnePrimeNum = new int[] { 4 };
        int[] expected = Array.Empty<int>();

        // Act
        int[] result = PrimeNumberFinder.GetAllPrimeNumbers(onlyOnePrimeNum);

        // Assert
        CollectionAssert.AreEqual(expected, result);
    }

    [Test]
    public void Test_GetAllPrimeNumbers_InputArrayWithNoPrimeNumbersOnly_ReturnsEmptyArray()
    {
        // Arrange
        int[] withNoPrimeNum = new int[] { 4, 6, 8, 9 };
        int[] expected = Array.Empty<int>();

        // Act
        int[] result = PrimeNumberFinder.GetAllPrimeNumbers(withNoPrimeNum);

        // Assert
        CollectionAssert.AreEqual(expected, result);
    }

    [Test]
    public void Test_GetAllPrimeNumbers_InputArrayWithOnlyOnePrimeNumber_ReturnsArrayWithTheSameNumber()
    {
        // Arrange
        int[] withOnlyOnePrimeNum = new int[] { 4, 5, 6, 8, 9 };
        int[] expected = new int[] { 5 };

        // Act
        int[] result = PrimeNumberFinder.GetAllPrimeNumbers(withOnlyOnePrimeNum);

        // Assert
        CollectionAssert.AreEqual(expected, result);
    }

    [Test]
    public void Test_GetAllPrimeNumbers_InputArrayWithMixedNumbers_ReturnsArrayOnlyWithPrimeNumbers()
    {
        // Arrange
        int[] withMixedNum = new int[] { 2, 4, 5, 6, 7, 8, 9 };
        int[] expected = new int[] { 2, 5, 7 };

        // Act
        int[] result = PrimeNumberFinder.GetAllPrimeNumbers(withMixedNum);

        // Assert
        CollectionAssert.AreEqual(expected, result);
    }
}
