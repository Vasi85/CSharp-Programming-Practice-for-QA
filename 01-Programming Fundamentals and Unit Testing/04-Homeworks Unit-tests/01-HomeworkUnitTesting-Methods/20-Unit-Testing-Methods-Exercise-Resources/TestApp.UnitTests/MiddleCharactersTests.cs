using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace TestApp.UnitTests;

public class MiddleCharactersTests
{
    [Test]
    public void Test_GetMiddleChars_EmptyString_ReturnsEmptyStringMessage()
    {
        // Arrange
        string input = string.Empty;
        string expected = "Empty string";

        // Act
        string result = MiddleCharacters.GetMiddleChars(input);

        // Assert
        Assert.AreEqual(result, expected);
    }

    [Test]
    public void Test_GetMiddleChars_WhiteSpaceString_ReturnsEmptyStringMessage()
    {
        // Arrange
        string input = " ";
        string expected = "Empty string";

        // Act
        string result = MiddleCharacters.GetMiddleChars(input);

        // Assert
        Assert.AreEqual(result, expected);
    }

    [Test]
    public void Test_GetMiddleChars_SingleCharacterString_ReturnsTheCharacter()
    {
        // Arrange
        string singleChar = "V";
        string expected = "V";

        // Act
        string result = MiddleCharacters.GetMiddleChars(singleChar);

        // Assert
        Assert.AreEqual(result, expected);
    }

    [Test]
    public void Test_GetMiddleChars_EvenStringLength_ReturnsTwoCharactersString()
    {
        // Arrange
        string evenString = "mama";
        string expected = "am";

        // Act
        string result = MiddleCharacters.GetMiddleChars(evenString);

        // Assert
        Assert.AreEqual(result, expected);
    }

    [Test]
    public void Test_GetMiddleChars_OddStringLength_ReturnsOneCharactersString()
    {
        // Arrange
        string evenString = "brother";
        string expected = "t";

        // Act
        string result = MiddleCharacters.GetMiddleChars(evenString);

        // Assert
        Assert.AreEqual(result, expected);
    }
}
