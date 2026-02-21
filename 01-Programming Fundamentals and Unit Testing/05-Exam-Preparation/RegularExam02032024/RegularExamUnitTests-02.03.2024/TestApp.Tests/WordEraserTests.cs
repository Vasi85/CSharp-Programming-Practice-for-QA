using System;
using System.Collections.Generic;
using NUnit.Framework;

namespace TestApp.Tests;

public class WordEraserTests
{
    
    [Test]
    public void Test_Erase_EmptyWordsList_ShouldReturnEmptyString()
    {
        List<string> emptyList = new();
        string word = "word";

        WordEraser instance = new WordEraser();
        string actual = instance.Erase(emptyList,word);

        Assert.That(actual, Is.EqualTo(string.Empty));
    }

    [Test]
    public void Test_Erase_NullWordsList_ShouldReturnEmptyString()
    {
        List<string> emptyList = null;
        string word = "word";

        WordEraser instance = new WordEraser();
        string actual = instance.Erase(emptyList, word);

        Assert.That(actual, Is.EqualTo(string.Empty));
    }

    [Test]
    public void Test_Erase_NullOrEmptyWordToErase_ShouldReturnStringOfGivenWordsList()
    {
        List<string> input = new() { "word" };
        string word = "";
        string expected = "word";

        WordEraser instance = new WordEraser();
        string actual = instance.Erase(input, word);

        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test_Erase_ValidInput_ShouldReturnEmptyString_WhenAllWordsMatchedTheWordToErase()
    {
        List<string> input = new() { "word", "word", "word" };
        string word = "word";

        WordEraser instance = new WordEraser();
        string actual = instance.Erase(input, word);

        Assert.That(actual, Is.EqualTo(string.Empty));
    }

    [Test]
    public void Test_Erase_ValidInput_ShouldReturnStringWithoutErasedWords_WhenFewOfWordsMatchedWordToArese()
    {
        List<string> input = new() { "word", "ball", "cat" };
        string word = "word";
        string expected = "ball cat";

        WordEraser instance = new WordEraser();
        string actual = instance.Erase(input, word);

        Assert.AreEqual(expected, actual);
    }
}

