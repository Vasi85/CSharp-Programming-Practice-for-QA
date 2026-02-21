using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace TestApp.UnitTests;

public class ListRemover_RemoveGreaterThanTests
{
    [Test]
    public void Test_RemoveElementsGreaterThan_EmptyListParameter_ReturnsEmtyList()
    {
        //Arrange
        List<int> emptyList = new List<int>();
        int threshold = 3;

        //Act
        List<int> actual = ListRemover.RemoveElementsGreaterThan(emptyList, threshold);

        //Assert
        Assert.That(actual, Is.Empty);
    }

    [Test]
    public void Test_RemoveElementsGreaterThan_ListWithGreaterThanThresholdElements_ReturnsEmtyList()
    {
        //Arrange
        List<int> greaterElements = new List<int>() { 5, 7, 53};
        int threshold = 3;

        //Act
        List<int> actual = ListRemover.RemoveElementsGreaterThan(greaterElements, threshold);

        //Assert
        Assert.That(actual, Is.Empty);
    }

    [Test]
    public void Test_RemoveElementsGreaterThan_ListWithLessThanOrEqualToThresholdElements_ReturnsSameList()
    {
        //Arrange
        List<int> lessElements = new List<int>() { 0, 1, 2 };
        int threshold = 3;

        //Act
        List<int> actual = ListRemover.RemoveElementsGreaterThan(lessElements, threshold);

        //Assert
        Assert.That(actual, Is.EqualTo(lessElements));
    }

    [Test]
    public void Test_RemoveElementsGreaterThan_ListWithLessThanEqualAndGreaterThanThresholdElements_ReturnsOnlyLessThanOrEqualToThreshold()
    {
        //Arrange
        List<int> mixedElements = new List<int>() { 0, 1, 2, 3, 4, 5 };
        int threshold = 3;
        List<int> expected = new List<int>() { 0, 1, 2, 3 };

        //Act
        List<int> actual = ListRemover.RemoveElementsGreaterThan(mixedElements, threshold);

        //Assert
        Assert.That(actual, Is.EqualTo(expected));
    }
}
