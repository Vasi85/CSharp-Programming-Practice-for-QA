using System.Linq;
using NUnit.Framework;
using System.Collections.Generic;

namespace TestApp.Tests;

public class HighestAsciiSumTests
{

    [Test]
    public void Test_FindStringWithHighestAsciiSum_EmptyList_ReturnsEmptyString()
    {
        List<string> emptyList = new();

        string actual = HighestAsciiSum.FindStringWithHighestAsciiSum(emptyList);

        Assert.That(actual, Is.Empty);
    }

    [Test]
    public void Test_FindStringWithHighestAsciiSum_NullList_ReturnsEmptyString()
    {
        List<string> nullList = null;

        string actual = HighestAsciiSum.FindStringWithHighestAsciiSum(nullList);

        Assert.That(actual, Is.Empty);
    }

    [Test]
    public void Test_FindStringWithHighestAsciiSum_OneElementInList_ReturnsThisString()
    {
        List<string> oneElement = new() { "a" };
        string exepted = "a";

        string actual = HighestAsciiSum.FindStringWithHighestAsciiSum(oneElement);

        Assert.AreEqual(exepted, actual);
    }

    [Test]
    public void Test_FindStringWithHighestAsciiSum_ManyElemenstInList_ReturnsHighestAsciiSumString()
    {
        List<string> oneElement = new() { "a", "b", "c" };
        string exepted = "c";

        string actual = HighestAsciiSum.FindStringWithHighestAsciiSum(oneElement);

        Assert.AreEqual(exepted, actual);
    }

    [Test]
    public void Test_FindStringWithHighestAsciiSum_ManyEqualValueStrings_ReturnsFirstString()
    {
        List<string> oneElement = new() { "a", "a", "a" };
        string exepted = "a";

        string actual = HighestAsciiSum.FindStringWithHighestAsciiSum(oneElement);

        Assert.AreEqual(exepted, actual);
    }
}
