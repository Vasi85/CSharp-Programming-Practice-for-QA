using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace TestApp.UnitTests;

public class ListManipulationTests
{
    [Test]
    public void Test_RemoveNegativesAndReverse_EmptyListInput_ReturnEmptyList()
    {
        // Arrange
        List<int> emptyList = new List<int>();

        // Act
        List<int> result = ListManipulation.RemoveNegativesAndReverse(emptyList);

        // Assert
        Assert.That(result, Is.Empty);
    }

    [Test]
    public void Test_RemoveNegativesAndReverse_OnlyNegativeNumbers_ReturnEmptyList()
    {
        // Arrange
        List<int> negativeNumList = new List<int>() { -1, -2, -3 };

        // Act
        List<int> result = ListManipulation.RemoveNegativesAndReverse(negativeNumList);

        // Assert
        Assert.That(result, Is.Empty);
    }

    [Test]
    public void Test_RemoveNegativesAndReverse_OnlyOnePositiveNumber_ReturnSameCollection()
    {
        // Arrange
        List<int> onePositiveNum = new List<int>() { 1, -2, -3 };
        List<int> expected = new() { 1 };

        // Act
        List<int> result = ListManipulation.RemoveNegativesAndReverse(onePositiveNum);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_RemoveNegativesAndReverse_OnlyPositiveNumbers_ReturnRevursedList()
    {
        // Arrange
        List<int> positiveNumList = new List<int>() { 1, 2, 3 };
        List<int> expected = new() { 3, 2, 1 };

        // Act
        List<int> result = ListManipulation.RemoveNegativesAndReverse(positiveNumList);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_RemoveNegativesAndReverse_PostiveAndNegativeElements_ReturnPositiveNumbersInReversedOrder()
    {
        // Arrange
        List<int> mixedNumList = new List<int>() { 1, 2, -3, -7, 12, -18 };
        List<int> expected = new() { 12, 2, 1 };

        // Act
        List<int> result = ListManipulation.RemoveNegativesAndReverse(mixedNumList);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }
}
