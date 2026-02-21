using NUnit.Framework;
using System;

namespace TestApp.Tests;

public class LongestIncreasingSubsequenceTests
{
    [Test]
    public void Test_GetLis_NullArray_ThrowsArgumentNullException()
    {
        int[] lis = null;

        Assert.That(() => LongestIncreasingSubsequence.GetLis(lis), Throws.ArgumentNullException);
    }

    [Test]
    public void Test_GetLis_EmptyArray_ReturnsEmptyString()
    {
        int[] lis = Array.Empty<int>();

        string result = LongestIncreasingSubsequence.GetLis(lis);

        Assert.AreEqual(string.Empty, result);
    }

    [Test]
    public void Test_GetLis_SingleElementArray_ReturnsElement()
    {
        int[] lis = new[] { 1 };

        string result = LongestIncreasingSubsequence.GetLis(lis);

        Assert.That(result, Is.EqualTo("1"));
    }

    [Test]
    public void Test_GetLis_UnsortedArray_ReturnsLongestIncreasingSubsequence()
    {
        int[] lisUnsort = new[] { 1, 15, 7, 12, 13, 3 };

        string result = LongestIncreasingSubsequence.GetLis(lisUnsort);
         
        Assert.That(result, Is.EqualTo("1 7 12 13"));
    }

    [Test]
    public void Test_GetLis_SortedArray_ReturnsItself()
    {
        int[] lisSorted = new[] { 1, 3, 7, 12, 13, 15 };

        string result = LongestIncreasingSubsequence.GetLis(lisSorted);

        Assert.That(result, Is.EqualTo("1 3 7 12 13 15"));
    }
}
