using NUnit.Framework;

using System;

namespace TestApp.UnitTests;

public class FakeTests
{
    [Test]
    public void Test_RemoveStringNumbers_RemovesDigitsFromCharArray()
    {
        // Arrange
        char[] digits = new char[] { 'w', '1', };
        char[] expected = new char[] { 'w' };
        
        // Act
        char[] actual = Fake.RemoveStringNumbers(digits);

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test_RemoveStringNumbers_NoDigitsInInput_ReturnsSameArray()
    {
        // Arrange
        char[] digits = new char[] { 'a', 'c', };
        char[] expected = new char[] { 'a', 'c' };

        // Act
        char[] actual = Fake.RemoveStringNumbers(digits);

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test_RemoveStringNumbers_EmptyArray_ReturnsEmptyArray()
    {
        // Arrange
        char[] digits = Array.Empty<char>();

        // Act
        char[] actual = Fake.RemoveStringNumbers(digits);

        // Assert
        Assert.That(actual, Is.Empty);
    }
}
