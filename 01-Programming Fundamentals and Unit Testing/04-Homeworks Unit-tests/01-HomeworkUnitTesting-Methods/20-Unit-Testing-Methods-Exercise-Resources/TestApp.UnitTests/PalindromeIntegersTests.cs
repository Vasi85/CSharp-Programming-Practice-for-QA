using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace TestApp.UnitTests;

public class PalindromeIntegersTests
{
    PalindromeIntegers pi;

    [SetUp]
    public void SetUp()
    {
        pi = new PalindromeIntegers();
    }

    [Test]
    public void Test_FindPalindromes_EmptyList_ReturnsEmptyList()
    {
        // Arrange
        List<int> emptyList = new List<int>();

        // Act
        List<int> result = pi.FindPalindromes(emptyList);

        // Assert
        Assert.That(result, Is.Empty);
    }

    [Test]
    public void Test_FindPalindromes_NoPalindromes_ReturnsEmptyList()
    {
        // Arrange
        List<int> noPalindromesList = new List<int>() { 100, 2007, 38965 };
        
        // Act
        List<int> result = pi.FindPalindromes(noPalindromesList);

        // Assert
        Assert.That(result, Is.Empty);
    }

    [Test]
    public void Test_FindPalindromes_OnlySingleDigitsElements_ReturnsSameIntegersList()
    {
        // Arrange
        List<int> singleDigitsElement = new List<int>() { 1, 2, 7, 3, 8, 9 };
        List<int> expected = new List<int>{ 1, 2, 7, 3, 8, 9 };

        // Act
        List<int> result = pi.FindPalindromes(singleDigitsElement);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_FindPalindromes_AllElementsArePalindromes_ReturnsSameIntegersList()
    {
        // Arrange
        List<int> AllElementsArePalindromes = new List<int>() { 101, 202, 7007, 3333, 878 };
        List<int> expected = new List<int> { 101, 202, 7007, 3333, 878 };

        // Act
        List<int> result = pi.FindPalindromes(AllElementsArePalindromes);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_FindPalindromes_PalimdromesAndNoPalindromesIntegers_ReturnsOnlyPalindromes()
    {
        // Arrange
        List<int> mixedElements = new List<int>() { 101, 20, 7007, 3523, 8787 };
        List<int> expected = new List<int> { 101, 7007 };

        // Act
        List<int> result = pi.FindPalindromes(mixedElements);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_FindPalindromes_NegativeElements_ReturnsOnlyPalindromes()
    {
        // Arrange
        List<int> negativeElements = new List<int>() { -101, -7007 };

        // Act
        List<int> result = pi.FindPalindromes(negativeElements);

        // Assert
        Assert.That(result, Is.Empty);
    }

    [Test]
    public void Test_FindPalindromes_NegativeAndPositiveElements_ReturnsOnlyPalindromes()
    {
        // Arrange
        List<int> mixedNegPosElements = new List<int>() { -101, 101, -7007, 5012, 404 };
        List<int> expected = new List<int> { 101, 404 };
        // Act
        List<int> result = pi.FindPalindromes(mixedNegPosElements);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }
}
