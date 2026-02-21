using NUnit.Framework;

namespace TestApp.UnitTests;

public class StringReverseTests
{
    // TODO: finish test
    [Test]
    public void Test_Reverse_WhenGivenEmptyString_ReturnsEmptyString()
    {
        // Arrange
        string input = new string(string.Empty);
        string expected = string.Empty;

        // Act
        var result = StringReverse.Reverse(input);

        // Assert
        Assert.AreEqual(expected, result);
    }

    [Test]
    public void Test_Reverse_WhenGivenSingleCharacterString_ReturnsSameCharacter()
    {
        string input = new string("a");
        string expected = "a";

        // Act
        var result = StringReverse.Reverse(input);

        // Assert
        Assert.AreEqual(expected, result);
    }

    [Test]
    public void Test_Reverse_WhenGivenNormalString_ReturnsReversedString()
    {
        string input = new string("word");
        string expected = "drow";

        // Act
        var result = StringReverse.Reverse(input);

        // Assert
        Assert.AreEqual(expected, result);
    }
}
