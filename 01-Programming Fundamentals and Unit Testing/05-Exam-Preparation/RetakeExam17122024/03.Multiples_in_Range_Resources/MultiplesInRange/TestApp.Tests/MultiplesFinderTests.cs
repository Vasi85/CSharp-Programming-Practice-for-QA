using System.Linq;
using NUnit.Framework;
using System.Collections.Generic;

namespace TestApp.Tests;

public class MultiplesFinderTests
{
    [Test]
    public void Test_FindMultiples_StartGreaterThanEndNumber_ReturnsErrorMessage()
    {
        int startGrearerNum = 20;
        int endNum = 10;
        int divisor = 5;
        string expected = "Start number should not be greater than end number.";

        string actual = MultiplesFinder.FindMultiples(startGrearerNum, endNum, divisor);

        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test_FindMultiples_NoMultiplesOfTheDevisor_ReturnsEmptyString()
    {
        int startGrearerNum = 1;
        int endNum = 3;
        int divisor = 7;
        //string expected = string.Empty;

        string actual = MultiplesFinder.FindMultiples(startGrearerNum, endNum, divisor);

        Assert.That(actual, Is.Empty);
    }

    [Test]
    public void Test_FindMultiples_SingleMultipleOfTheDevisor_ReturnsSingleNumber()
    {
        int startGrearerNum = 3;
        int endNum = 4;
        int divisor = 3;
        string expected = "3";

        string actual = MultiplesFinder.FindMultiples(startGrearerNum, endNum, divisor);

        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test_FindMultiples_ManyMultiplesOfTheDevisor_ReturnsCorrectNumbersInRange()
    {
        int startGrearerNum = 5;
        int endNum = 15;
        int divisor = 3;
        string expected = "6 9 12 15";

        string actual = MultiplesFinder.FindMultiples(startGrearerNum, endNum, divisor);

        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test_FindMultiples_ZeroInRange_ReturnsZero()
    {
        int startGrearerNum = 0;
        int endNum = 0;
        int divisor = 1;
        string expected = "0";

        string actual = MultiplesFinder.FindMultiples(startGrearerNum, endNum, divisor);

        Assert.That(actual, Is.EqualTo(expected));
    }
}