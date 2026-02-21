using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace TestApp.UnitTests;

public class SignOfIntegerNumbersTests
{
    [TestCase(" ")]
    [TestCase("7.2")]
    [TestCase("word")]
    public void Test_CheckSign_NotAnIntegerValue_ReturnErrorMessage(string input)
    {
        // Arrange
        string expected = "The input is not an integer!";

        // Act
        string result = SignOfIntegerNumbers.CheckSign(expected);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_CheckSign_ZeroValueInput_ReturnMessageForZero()
    {
        // Arrange
        string number = "0";
        string expected = $"The number {number} is zero.";

        // Act
        string result = SignOfIntegerNumbers.CheckSign(number);

        // Assert
        Assert.That(result, Is.EqualTo(expected));

    }

    [Test]
    public void Test_CheckSign_NegativeValueInput_ReturnMessageForNegativeInteger()
    {
        // Arrange
        string negativeNumber = "-7";
        string expected = $"The number {negativeNumber} is negative.";

        // Act
        string result = SignOfIntegerNumbers.CheckSign(negativeNumber);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_CheckSign_PositiveValueInput_ReturnMessageForPositiveInteger()
    {
        // Arrange
        string positiveNumber = "7";
        string expected = $"The number {positiveNumber} is positive.";

        // Act
        string result = SignOfIntegerNumbers.CheckSign(positiveNumber);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }
}
