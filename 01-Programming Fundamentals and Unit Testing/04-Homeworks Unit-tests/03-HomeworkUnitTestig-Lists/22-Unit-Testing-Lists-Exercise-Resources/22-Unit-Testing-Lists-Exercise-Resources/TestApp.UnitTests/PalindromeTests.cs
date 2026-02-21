using NUnit.Framework;

using System.Collections.Generic;
using System.Data.Common;

namespace TestApp.UnitTests;

public class PalindromeTests
{
    [Test]
    public void Test_IsPalindrome_ValidPalindrome_ReturnsTrue()
    {
        // Arrange
        List<string> palindromes = new List<string> { "madam", "mom", "dad" };

        // Act
        bool result = Palindrome.IsPalindrome(palindromes);

        // Assert
        Assert.IsTrue(result);
    }

    [Test]
    public void Test_IsPalindrome_EmptyList_ReturnsTrue()
    {
        // Arrange
        List<string> emptyList = new();

        // Act
        bool result = Palindrome.IsPalindrome(emptyList);

        // Assert
        Assert.IsTrue(result);
    }

    [Test]
    public void Test_IsPalindrome_SingleWord_ReturnsTrue()
    {
        // Arrange
        List<string> singleWord = new List<string> { "level" };

        // Act
        bool result = Palindrome.IsPalindrome(singleWord);

        // Assert
        Assert.IsTrue(result);
    }

    [Test]
    public void Test_IsPalindrome_NonPalindrome_ReturnsFalse()
    {
        // Arrange
        List<string> nonPalindrome = new List<string> { "cat" };

        // Act
        bool result = Palindrome.IsPalindrome(nonPalindrome);

        // Assert
        Assert.IsFalse(result);
    }

    [Test]
    public void Test_IsPalindrome_MixedCasePalindrome_ReturnsTrue()
    {
        // Arrange
        List<string> mixedPalindrome = new List<string> { "Madam", "Level" };

        // Act
        bool result = Palindrome.IsPalindrome(mixedPalindrome);

        // Assert
        Assert.IsTrue(result);
    }
}
