using NUnit.Framework;

using System;

namespace TestApp.UnitTests;

public class ArticleTests
{
    private Article _article;

    [SetUp]
    public void SetUp()
    {
        _article = new Article();
    }

    // TODO: finish test
    [Test]
    public void Test_AddArticles_ReturnsArticleWithCorrectData()
    {
        // Arrange
        string[] input = {"Article1 Content1 Author1", "Article2 Content2 Author2", "Article3 COntent3 Author3"};

        // Act
        Article result = _article.AddArticles(input);

        // Assert
        Assert.That(result.ArticleList, Has.Count.EqualTo(3));
        Assert.That(result.ArticleList[0].Title, Is.EqualTo("Article1"));
        Assert.That(result.ArticleList[1].Content, Is.EqualTo("Content2"));
        Assert.That(result.ArticleList[2].Author, Is.EqualTo("Author3"));
    }

    [Test]
    public void Test_GetArticleList_SortsArticlesByTitle()
    {
        // Arrange
        _article.ArticleList.Add(new Article
        {
            Author = "A1",
            Content = "C1",
            Title = "T2"
        });
        _article.ArticleList.Add(new Article
        {
            Author = "A2",
            Content = "C2",
            Title = "T3"
        });
        _article.ArticleList.Add(new Article
        {
            Author = "A3",
            Content = "C3",
            Title = "T1"
        });
        string printCriteria = "title";
        string expected =
            "T1 - C3: A3"
            + Environment.NewLine +
             "T2 - C1: A1"
            + Environment.NewLine +
             "T3 - C2: A2";

        // Act
        string result = _article.GetArticleList(_article, printCriteria);

        // Assert
        Assert.That(result, Is.EqualTo(expected));

    }

    [Test]
    public void Test_GetArticleList_ReturnsEmptyString_WhenInvalidPrintCriteria()
    {
        // Arrange
        _article.ArticleList.Add(new Article
        {
            Author = "A1",
            Content = "C1",
            Title = "T2"
        });
        _article.ArticleList.Add(new Article
        {
            Author = "A2",
            Content = "C2",
            Title = "T3"
        });
        _article.ArticleList.Add(new Article
        {
            Author = "A3",
            Content = "C3",
            Title = "T1"
        });
        string printCriteria = "Story";

        // Act
        string result = _article.GetArticleList(_article, printCriteria);

        // Assert
        Assert.That(result, Is.Empty);
    }
}
