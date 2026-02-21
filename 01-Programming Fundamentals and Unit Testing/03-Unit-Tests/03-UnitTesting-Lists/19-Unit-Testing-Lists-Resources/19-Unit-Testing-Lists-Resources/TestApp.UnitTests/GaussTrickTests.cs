using NUnit.Framework;

using System.Collections.Generic;

namespace TestApp.UnitTests;

public class GaussTrickTests
{
    [Test]
    public void Test_SumPairs_InputIsEmptyList_ShouldReturnEmptyList()
    {
        // Arrange
        List<int> emptyList = new();

        // Act
        List<int> result = GaussTrick.SumPairs(emptyList);

        // Assert
        CollectionAssert.AreEqual(emptyList, result);
    }

    [Test]
    public void Test_SumPairs_InputHasSingleElement_ShouldReturnSameElement()
    {
        // Arrange
        List<int> singleElement = new List<int>() { 15 };
        // Act
        List<int> result = GaussTrick.SumPairs(singleElement);

        // Assert
        CollectionAssert.AreEqual(singleElement, result);
    }

    [Test]
    public void Test_SumPairs_InputHasEvenCountElements_ShouldReturnSumPairs()
    {
        // Arrange
        List<int> evenCountElements = new List<int> { 1, 2, 3, 4 };
        List<int> expected = new List<int> { 5, 5 };

        // Act
        List<int> result = GaussTrick.SumPairs(evenCountElements);

        // Assert
        CollectionAssert.AreEqual(expected, result);
    }

    [Test]
    public void Test_SumPairs_InputHasOddCountElements_ShouldReturnWithMiddleElement()
    {
        // Arrange
        List<int> oddCountElements = new List<int> { 1, 2, 3, 4, 5 };
        List<int> expected = new List<int> { 6, 6, 3 };

        // Act
        List<int> result = GaussTrick.SumPairs(oddCountElements);

        // Assert
        CollectionAssert.AreEqual(expected, result);
    }

    [Test]
    public void Test_SumPairs_InputHasLargeEvenCountElements_ShouldReturnSumPairs()
    {
        // Arrange
        List<int> largeEvenCountElements = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8 };
        List<int> expected = new List<int> { 9, 9, 9, 9 };

        // Act
        List<int> result = GaussTrick.SumPairs(largeEvenCountElements);

        // Assert
        CollectionAssert.AreEqual(expected, result);
    }

    [Test]
    public void Test_SumPairs_InputHasLargeOddCountElements_ShouldReturnWithMiddleElement()
    {
        // Arrange
        List<int> largeOddCountElements = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        List<int> expected = new List<int> { 10, 10, 10, 10, 5 };

        // Act
        List<int> result = GaussTrick.SumPairs(largeOddCountElements);

        // Assert
        CollectionAssert.AreEqual(expected, result);
    }
}
