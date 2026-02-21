using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace TestApp.UnitTests;

public class TopIntegersTests
{
    [Test]
    public void Test_FindTopIntegers_EmptyArrayParameter_ReturnEmptyString()
    {
        // Arrange
        int[] emptyArray = Array.Empty<int>();

        // Act
        TopIntegers instance = new TopIntegers();
        string actual = instance.FindTopIntegers(emptyArray);

        // Assert
        Assert.That(actual, Is.Empty);
    }

    [Test]
    public void Test_FindTopIntegers_AllElementsAreTopIntegers_ReturnStringWithAllElements()
    {
        // Arrange
        int[] allTopInt = new int[] { 12, 10, 8 };
        string expected = "12 10 8";

        // Act
        TopIntegers instance = new TopIntegers();
        string actual = instance.FindTopIntegers(allTopInt);

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test_FindTopIntegers_OnlyOneElementArray_ReturnStringWithOneInteger()
    {
        // Arrange
        int[] onlyOneElement = new int[] { 12 };
        string expected = "12";

        // Act
        TopIntegers instance = new TopIntegers();
        string actual = instance.FindTopIntegers(onlyOneElement);

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test_FindTopIntegers_OnlySomeElementsAreTopIntegers_ReturnStringWithOnlyTopIntegers()
    {
        // Arrange
        int[] onlySomeTopInt = new int[] { 75, 53, 52, 55, 12, 18 };
        string expected = "75 55 18";

        // Act
        TopIntegers instance = new TopIntegers();
        string actual = instance.FindTopIntegers(onlySomeTopInt);

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }
}

