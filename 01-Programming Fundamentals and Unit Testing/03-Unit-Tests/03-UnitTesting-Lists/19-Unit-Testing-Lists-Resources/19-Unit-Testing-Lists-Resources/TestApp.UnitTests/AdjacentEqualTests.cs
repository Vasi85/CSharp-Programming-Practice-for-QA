using NUnit.Framework;

using System.Collections.Generic;

namespace TestApp.UnitTests;

public class AdjacentEqualTests
{
    [Test]
    public void Test_Sum_InputIsEmptyList_ShouldReturnEmptyString()
    {
        // Arrange
        List<int> emptyList = new();

        // Act
        string result = AdjacentEqual.Sum(emptyList);

        // Assert
        Assert.That(result, Is.Empty);
    }

    [Test]
    public void Test_Sum_NoAdjacentEqualNumbers_ShouldReturnOriginalList()
    {
        // Arrange
        List<int> noAdjecentEqualNum = new List<int>() { 1, 2, 3, 4, 5 };
        string expected = "1 2 3 4 5";

        // Act
        string result = AdjacentEqual.Sum(noAdjecentEqualNum);

        // Assert
        Assert.That(result, Is.EqualTo("1 2 3 4 5"));
    }

    [Test]
    public void Test_Sum_AdjacentEqualNumbersExist_ShouldReturnSummedList()
    {
        // Arrange
        List<int> AdjecentEqualNum = new List<int>() { 1, 2, 5, 3, 4, 5 };
        string expected = "1 2 5 3 4 5";

        // Act
        string result = AdjacentEqual.Sum(AdjecentEqualNum);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_Sum_AllNumbersAreAdjacentEqual_ShouldReturnSingleSummedNumber()
    {
        // Arrange
        List<int> allAdjecentNum = new List<int>() { 1, 1, 1 };
        string expected = "3";

        // Act
        string result = AdjacentEqual.Sum(allAdjecentNum);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_Sum_AdjacentEqualNumbersAtBeginning_ShouldReturnSummedList()
    {
        // Arrange
        List<int> adjecentNumAtBeginning = new List<int>() { 1, 1, 2, 3, 4, 5 };
        string expected = "2 2 3 4 5";

        // Act
        string result = AdjacentEqual.Sum(adjecentNumAtBeginning);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_Sum_AdjacentEqualNumbersAtEnd_ShouldReturnSummedList()
    {
        // Arrange
        List<int> adjecentNumAtEnd = new List<int>() { 1, 2, 3, 4, 5, 5 };
        string expected = "1 2 3 4 10";

        // Act
        string result = AdjacentEqual.Sum(adjecentNumAtEnd);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_Sum_AdjacentEqualNumbersInMiddle_ShouldReturnSummedList()
    {
        // Arrange
        List<int> adjecentNumInMiddle = new List<int>() { 1, 2, 3, 3, 4, 5 };
        string expected = "1 2 6 4 5";

        // Act
        string result = AdjacentEqual.Sum(adjecentNumInMiddle);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_Sum_TwoAdjacentEqualNumbersInMiddle_ShouldReturnSummedList()
    {
        // Arrange
        List<int> twoAdjecentNum = new List<int>() { 1, 2, 2, 3, 4, 4, 5 };
        string expected = "1 4 3 8 5";

        // Act
        string result = AdjacentEqual.Sum(twoAdjecentNum);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }
}
