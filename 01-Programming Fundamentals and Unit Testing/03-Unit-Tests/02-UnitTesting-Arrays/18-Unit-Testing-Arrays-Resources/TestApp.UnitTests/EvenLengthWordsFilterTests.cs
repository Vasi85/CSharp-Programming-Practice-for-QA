using NUnit.Framework;

namespace TestApp.UnitTests;

public class EvenLengthWordsFilterTests
{
    [Test]
    public void Test_GetEvenWords_InputArrayWithEmptyStrings_ShouldReturnEmptyString()
    {
        // Arrange
        string[] empty = new string[] { "" };
        string[] expected = { string.Empty };

        // Act
        string result = EvenLengthWordsFilter.GetEvenWords(empty);

        // Assert
        Assert.That(result, Is.Empty);
    }

    [Test]
    public void Test_GetEvenWords_InputArrayWithOneOddLengthWord_ShouldReturnEmptyString()
    {
        // Arrange
        string[] oddWord = new string[] { "dad" };
        string expected = string.Empty;

        // Act
        string result = EvenLengthWordsFilter.GetEvenWords(oddWord);

        // Assert
        Assert.That(result, Is.Empty);
    }

    [Test]
    public void Test_GetEvenWords_InputArrayOnlyWithOddLengthWords_ShouldReturnEmptyString()
    {
        // Arrange
        string[] onlyOddLengthWords = new string[] { "dad", "mom", "cat" };
        string expected =  string.Empty ;

        // Act
        string result = EvenLengthWordsFilter.GetEvenWords(onlyOddLengthWords);

        // Assert
        Assert.That(result, Is.Empty);
    }

    [Test]
    public void Test_GetEvenWords_InputArrayWithOneEvenLengthWord_ShouldReturnSameWord()
    {
        // Arrange
        string[] oneEvenLengthWord = new string[] { "dad", "mom", "baby" };
        string expected = "baby";

        // Act
        string result = EvenLengthWordsFilter.GetEvenWords(oneEvenLengthWord);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_GetEvenWords_InputArrayWithEvenAndOddLengthWords_ShouldReturnOnlyEvenLengthWords()
    {
        // Arrange
        string[] oddEndEvenLengthWord = new string[] { "dad", "mama", "baby", "cat" };
        string expected = "mama baby";

        // Act
        string result = EvenLengthWordsFilter.GetEvenWords(oddEndEvenLengthWord);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }
}

