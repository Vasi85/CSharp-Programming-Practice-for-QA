using System;
using NUnit.Framework;

namespace TestApp.Tests;
public class PrimeNumbersTests
{
    [Test]
    public void Test_GetPrimeNumbersInRange_StartNumberBiggerThanEndNumber_ReturnsErrorMessage()
    {
        int startNum = 10;
        int endNum = 1;
        string expected = "Start number should be bigger than end number.";

        string nums = PrimeNumbers.GetPrimeNumbersInRange(startNum, endNum);

        Assert.That(nums, Is.EqualTo(expected));
    }

    [Test]
    public void Test_GetPrimeNumbersInRange_StartAndEndNumberAreEqual_ReturnsEmptyString()
    {
        int startNum = 1;
        int endNum = 1;

        string nums = PrimeNumbers.GetPrimeNumbersInRange(startNum, endNum);

        Assert.That(nums, Is.Empty);
    }

    [Test]
    public void Test_GetPrimeNumbersInRange_NoPrimeNumbers_ReturnsEmptyString()
    {
        int startNum = 0;
        int endNum = 1;

        string nums = PrimeNumbers.GetPrimeNumbersInRange(startNum, endNum);

        Assert.That(nums, Is.Empty);
    }

    [Test]
    public void Test_GetPrimeNumbersInRange_WithPrimeAndNonPrimeNumbers_ReturnsOnlyPrimeNumbers()
    {
        int startNum = 1;
        int endNum = 50;
        string expected = "2 3 5 7 11 13 17 19 23 29 31 37 41 43 47";

        string nums = PrimeNumbers.GetPrimeNumbersInRange(startNum, endNum);

        Assert.That(nums, Is.EqualTo(expected));
    }

    [Test]
    public void Test_GetPrimeNumbersInRange_OnlyPrimeNumbers_ReturnsAllNumbers()
    {
        int startNum = 2;
        int endNum = 3;
        string expected = "2 3";

        string nums = PrimeNumbers.GetPrimeNumbersInRange(startNum, endNum);

        Assert.That(nums, Is.EqualTo(expected));
    }
}

