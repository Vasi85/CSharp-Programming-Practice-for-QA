using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace TestApp.UnitTests;

public class IgnoreTheCharsTests
{
    [Test]
    public void Test_IgnoreChars_EmptyStringSentence_ReturnsEmptyString()
    {
        // Arrange
        string empty = "";
        List<char> input = new List<char>() { 'a', 'b' };

        // Act
        string result = IgnoreTheChars.IgnoreChars(empty, input);

        // Assert
        Assert.That(result, Is.Empty);
    }

    [Test]
    public void Test_IgnoreChars_EmptyList_ReturnsSameSentence()
    {
        // Arrange
        string sentence = "I love my mom";
        List<char> empty = new List<char>();

        // Act
        string result = IgnoreTheChars.IgnoreChars(sentence, empty);

        // Assert
        Assert.That(result, Is.EqualTo(sentence));
    }

    [Test]
    public void Test_IgnoreChars_OneCharSentenceAndSameCharsForIgnoring_ReturnsEmptyString()
    {
        // Arrange
        string sentence = "A";
        List<char> ignorChar = new List<char>() { 'A' };

        // Act
        string result = IgnoreTheChars.IgnoreChars(sentence, ignorChar);

        // Assert
        Assert.That(result, Is.Empty);
    }

    [Test]
    public void Test_IgnoreChars_WholeSentenceAndFewCharsToIgnore_ReturnsCorrectString()
    {
        // Arrange
        string sentence = "I love my mom";
        List<char> ignorChar = new List<char>() { 'l', 'y' };
        string expected = "I ove m mom";

        // Act
        string result = IgnoreTheChars.IgnoreChars(sentence, ignorChar);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }
}
