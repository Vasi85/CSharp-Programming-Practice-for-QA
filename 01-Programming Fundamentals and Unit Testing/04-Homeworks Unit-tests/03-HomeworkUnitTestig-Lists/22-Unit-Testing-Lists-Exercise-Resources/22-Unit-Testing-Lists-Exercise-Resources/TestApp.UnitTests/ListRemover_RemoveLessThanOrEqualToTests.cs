using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace TestApp.UnitTests;

public class ListRemover_RemoveLessThanOrEqualToTests
{
    [Test]
    public void Test_RemoveElementsLessThanOrEqualTo_EmptyListParameter_ReturnsEmtyList()
    {
        //Arrange
        List<int> emptyList = new List<int>();
        int threshold = 3;

        //Act
        List<int> actual = ListRemover.RemoveElementsLessThanOrEqualTo(emptyList, threshold);

        //Assert
        Assert.That(actual, Is.Empty);
    }

    [Test]
    public void Test_RemoveElementsLessThanOrEqualTo_ListWithLessThanOrEqualToThresholdElements_ReturnsEmtyList()
    {
        //Arrange
        List<int> lessOrEqualElements = new List<int>() { 1, 2, 3 };
        int threshold = 3;

        //Act
        List<int> actual = ListRemover.RemoveElementsLessThanOrEqualTo(lessOrEqualElements, threshold);

        //Assert
        Assert.That(actual, Is.Empty);
    }

    [Test]
    public void Test_RemoveElementsLessThanOrEqualTo_ListWithOnlyGreaterThanThresholdElements_ReturnsSameList()
    {
        //Arrange
        List<int> greaterElements = new List<int>() { 5, 7, 53 };
        int threshold = 3;
        List<int> expected = new List<int>() { 5, 7, 53 };

        //Act
        List<int> actual = ListRemover.RemoveElementsLessThanOrEqualTo(greaterElements, threshold);

        //Assert
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test_RemoveElementsLessThanOrEqualTo_ListWithLessThanEqualAndGreaterThanThresholdElements_ReturnsOnlyGreaterThanThreshold()
    {
        //Arrange
        List<int> mixedElements = new List<int>() { 0, 1, 2, 3, 4, 5 };
        int threshold = 3;
        List<int> expected = new List<int>() { 4, 5 };

        //Act
        List<int> actual = ListRemover.RemoveElementsLessThanOrEqualTo(mixedElements, threshold);

        //Assert
        Assert.That(actual, Is.EqualTo(expected));
    }
}
