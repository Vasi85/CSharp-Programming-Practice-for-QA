using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using NUnit.Framework.Interfaces;
using NUnit.Framework.Internal.Execution;

namespace TestApp.UnitTests;

public class ListSplitterTests
{
    [Test]
    public void Test_SplitEvenAndOdd_EmptyListParameter_ReturnsEmptyEvenAndOddLists()
    {
        //Arrange
        List<int> emptyList = new();

        //Act
        var (even, odd) = ListSplitter.SplitEvenAndOdd(emptyList);

        //Assert
        Assert.That(even, Is.Empty);
        Assert.That(odd, Is.Empty);
    }

    [Test]
    public void Test_SplitEvenAndOdd_OnlyEvenValues_ReturnsEmptyOddList()
    {
        //Arrange
        List<int> evenList = new() { 2, 4, 6 };

        //Act
        (List<int>even, List<int>odd) result = ListSplitter.SplitEvenAndOdd(evenList);

        //Assert
        Assert.That(result.odd, Is.Empty);
    }

    [Test]
    public void Test_SplitEvenAndOdd_OnlyOddValues_ReturnsEmptyEvenList()
    {
        //Arrange
        List<int> oddList = new() { 1, 3, 5, 7 };

        //Act
        (List<int>even, List<int>odd) result = ListSplitter.SplitEvenAndOdd(oddList);

        //Assert
        Assert.That(result.even, Is.Empty);
    }

    [Test]
    public void Test_SplitEvenAndOdd_EvenAndOddValues_ReturnsListWithCorrectValues()
    {
        //Arrange
        List<int> mixedNum = new() { 1, 2, 3, 4 };
        List<int> evenNum = new() { 2, 4 };
        List<int> oddNum = new() { 1, 3  };

        //Act
        (List<int> even, List<int> odd) result = ListSplitter.SplitEvenAndOdd(mixedNum);

        //Assert
        Assert.That(result.even, Is.EqualTo(evenNum));
        Assert.That(result.odd, Is.EqualTo(oddNum));
    }
}
