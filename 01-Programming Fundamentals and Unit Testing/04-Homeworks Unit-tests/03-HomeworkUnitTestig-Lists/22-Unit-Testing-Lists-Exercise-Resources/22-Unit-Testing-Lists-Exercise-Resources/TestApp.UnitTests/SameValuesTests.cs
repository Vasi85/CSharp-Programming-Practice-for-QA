using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace TestApp.UnitTests;

public class SameValuesTests
{
    [Test]
    public void Test_FindSameValues_EmptyFirstList_ReturnsEmptyList()
    {
        //Arrange
        List<int> firstEmptyList = new List<int>();
        List<int> secondList = new List<int>() { 1, 2, 3};
        List<int> expected = new List<int>();

        //Act
        List<int> actual = SameValues.FindSameValues(firstEmptyList, secondList);

        //Assert
        Assert.That(actual, Is.Empty);
    }

    [Test]
    public void Test_FindSameValues_EmptySecondList_ReturnsEmptyList()
    {
        //Arrange
        List<int> firstList = new List<int>() { 1, 2, 3 };
        List<int> secondEmptyList = new List<int>();
        List<int> expected = new List<int>();

        //Act
        List<int> actual = SameValues.FindSameValues(firstList, secondEmptyList);

        //Assert
        Assert.That(actual, Is.Empty);
    }

    [Test]
    public void Test_FindSameValues_NoSameValuesInBothLists_ReturnsEmptyList()
    {
        //Arrange
        List<int> firstList = new List<int>() { 1, 2, 3 };
        List<int> secondList = new List<int>() { 4, 5, 6 };
        List<int> expected = new List<int>();

        //Act
        List<int> actual = SameValues.FindSameValues(firstList, secondList);

        //Assert
        Assert.That(actual, Is.Empty);
    }

    [Test]
    public void Test_FindSameValues_BothListWithSameValues_ReturnsListWithSameValues()
    {
        //Arrange
        List<int> firstList = new List<int>() { 1, 2, 3 };
        List<int> secondList = new List<int>() { 1, 2, 3 };
        List<int> expected = new List<int>() { 1, 2, 3 };

        //Act
        List<int> actual = SameValues.FindSameValues(firstList, secondList);

        //Assert
        Assert.That(actual, Is.EqualTo(expected));
    }
}
