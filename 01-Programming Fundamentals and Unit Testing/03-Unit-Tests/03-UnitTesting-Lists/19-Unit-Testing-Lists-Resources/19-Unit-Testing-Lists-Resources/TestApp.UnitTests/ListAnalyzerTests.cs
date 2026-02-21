using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace TestApp.UnitTests;

public class ListAnalyzerTests
{
    [Test]
    public void Test_Analyze_EmptyList_ShouldReturnNoElementsMsg()
    {
        // Arrange
        List<int> emptyList = new List<int>();
        string expected = "No elements!";

        // Act
        string result = ListAnalyzer.Analyze(emptyList);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_Analyze_OneElement_ShouldReturnSameValueForMinMaxAvg()
    {
        // Arrange
        List<int> oneElement = new List<int>() { 5 };
        string expected = "Element count: 1, Min value: 5, Max value: 5, Avg: 5.00.";

        // Act
        string result = ListAnalyzer.Analyze(oneElement);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_Analyze_OnlySameValueElements_ShouldReturnSameValueForMinMaxAvg()
    {
        // Arrange
        List<int> sameValueElements = new List<int>() { 5, 5, 5 };
        string expected = "Element count: 3, Min value: 5, Max value: 5, Avg: 5.00.";

        // Act
        string result = ListAnalyzer.Analyze(sameValueElements);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_Analyze_DiffrentValues_ShouldReturnCorrectValues()
    {
        // Arrange
        List<int> diffrentValueElements = new List<int>() { 1, 2, 3 };
        string expected = "Element count: 3, Min value: 1, Max value: 3, Avg: 2.00.";

        // Act
        string result = ListAnalyzer.Analyze(diffrentValueElements);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }
}
