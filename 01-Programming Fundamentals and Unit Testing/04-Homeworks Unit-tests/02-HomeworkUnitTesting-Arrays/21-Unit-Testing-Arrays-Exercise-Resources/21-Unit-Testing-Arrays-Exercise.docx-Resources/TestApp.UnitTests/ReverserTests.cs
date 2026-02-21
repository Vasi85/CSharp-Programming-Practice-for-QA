using NUnit.Framework;

using System;

namespace TestApp.UnitTests;

public class ReverserTests
{
    [Test]
    public void Test_ReverseStrings_WithEmptyArray_ReturnsEmptyArray()
    {
        // Arrange
        string[] inputArray = Array.Empty<string>();

        // Act
        string[] result = Reverser.ReverseStrings(inputArray);

        // Assert
        Assert.That(result, Is.Empty);
    }

    // TODO: finish test
    [Test]
    public void Test_ReverseStrings_WithSingleString_ReturnsReversedString()
    {
        // Arrange
        string[] singleString = new string[] { "Hello" };
        string[] expected = new string[] { "olleH" };
        // Act
        string[] result = Reverser.ReverseStrings(singleString);

        // Assert
        Assert.That(result, Is.EqualTo(new[] { "olleH" }));
    }

    [Test]
    public void Test_ReverseStrings_WithMultipleStrings_ReturnsReversedStrings()
    {
        // Arrange
        string[] multipleString = new string[] { "Hello", "World" };
        string[] expected = new string[] { "olleH", "dlroW" };
        // Act
        string[] result = Reverser.ReverseStrings(multipleString);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_ReverseStrings_WithSpecialCharacters_ReturnsReversedSpecialCharacters()
    {
        // Arrange
        string[] multipleString = new string[] { "*Hello", "%World!" };
        string[] expected = new string[] { "olleH*", "!dlroW%"  };
        // Act
        string[] result = Reverser.ReverseStrings(multipleString);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }
}
