using System;
using NUnit.Framework;

namespace TestApp.UnitTests;

public class TriangleTests
{
    [Test]
    public void Test_Triangle_OutputMatchesExpected_Size0()
    {
        // Arrange
        int num = 0;
        
        // Act
        string result = Triangle.PrintTriangle(num);
        

        // Assert
        Assert.That(result, Is.Empty);
    }

    [Test]
    public void Test_Triangle_OutputMatchesExpected_Size3()
    {
        // Arrange
        int num = 3;
        string expected =    $"1" +
        $"{Environment.NewLine}1 2" +
        $"{Environment.NewLine}1 2 3" +
        $"{Environment.NewLine}1 2" +
        $"{Environment.NewLine}1";

        // Act
        string result = Triangle.PrintTriangle(num);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_Triangle_OutputMatchesExpected_Size5()
    {
        // Arrange
        int num = 5;
        string expected = $"1" +
        $"{Environment.NewLine}1 2" +
        $"{Environment.NewLine}1 2 3" +
        $"{Environment.NewLine}1 2 3 4" +
        $"{Environment.NewLine}1 2 3 4 5" +
        $"{Environment.NewLine}1 2 3 4" +
        $"{Environment.NewLine}1 2 3" +
        $"{Environment.NewLine}1 2" +
        $"{Environment.NewLine}1";

        // Act
        string result = Triangle.PrintTriangle(num);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }
}
