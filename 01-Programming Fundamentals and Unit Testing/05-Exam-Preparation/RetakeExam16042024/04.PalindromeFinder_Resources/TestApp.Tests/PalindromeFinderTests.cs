using System;
using System.Collections.Generic;
using NUnit.Framework;

namespace TestApp.Tests;
public class PalindromeFinderTests
{
    [Test]
    public void Test_GetPalindromes_NullWordsList_ReturnsEmptyString()
    {
        List<string> nullList = null;

        string actual = PalindromeFinder.GetPalindromes(nullList);

        Assert.That(actual, Is.Empty);
    }

    [Test]
    public void Test_GetPalindromes_EmptyWordsList_ReturnsEmptyString()
    {
        List<string> emptyList = new();

        string actual = PalindromeFinder.GetPalindromes(emptyList);

        Assert.That(actual, Is.Empty);
    }

    [Test]
    public void Test_GetPalindromes_ListWithWords_ReturnsOnlyPalidromeWords()
    {
        List<string> listWithWords = new() { "cat", "dad", "Level", "Mom"};
        string expected = "dad Level Mom";

        string actual = PalindromeFinder.GetPalindromes(listWithWords);

        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test_GetPalindromes_ListWithoutPalindromeWords_ReturnsEmptyString()
    {
        List<string> listWithoutPalindromes = new() { "cat", "ball", "doll", "Mommy" };

        string actual = PalindromeFinder.GetPalindromes(listWithoutPalindromes);

        Assert.That(actual, Is.Empty);
    }

    [Test]
    public void Test_GetPalindromes_ListOnlyWithPalidromeWords_ReturnsStringWithAllWords()
    {
        List<string> listWithWords = new() { "dad", "Level", "Mom" };
        string expected = "dad Level Mom";

        string actual = PalindromeFinder.GetPalindromes(listWithWords);

        Assert.That(actual, Is.EqualTo(expected));
    }
}

