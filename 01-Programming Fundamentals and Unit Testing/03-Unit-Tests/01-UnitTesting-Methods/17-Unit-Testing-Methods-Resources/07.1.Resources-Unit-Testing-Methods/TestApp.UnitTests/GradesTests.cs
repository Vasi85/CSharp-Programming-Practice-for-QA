using NUnit.Framework;

namespace TestApp.UnitTests;

public class GradesTests
{
    [TestCase(2.50, "Fail")]
    [TestCase(3.40, "Average")]
    [TestCase(4.00, "Good")]
    [TestCase(5.10, "Very Good")]
    [TestCase(5.80, "Excellent")]
    [TestCase(7.00, "Invalid!")]
    public void Test_GradeAsWords_ReturnsCorrectString(double grade, string expected)
    {
        // Arrange

        // Act
        string actual = Grades.GradeAsWords(grade);

        // Assert
        Assert.AreEqual(expected, actual);
    }

    [TestCase(2.00, "Fail")]
    [TestCase(2.99, "Fail")]
    [TestCase(3.00, "Average")]
    [TestCase(3.49, "Average")]
    [TestCase(3.50, "Good")]
    [TestCase(4.49, "Good")]
    [TestCase(4.50, "Very Good")]
    [TestCase(5.49, "Very Good")]
    [TestCase(5.50, "Excellent")]
    [TestCase(6.00, "Excellent")]
    [TestCase(1.99, "Invalid!")]
    [TestCase(6.01, "Invalid!")]
    public void Test_GradeAsWords_ReturnsCorrectString_EdgeCases(double grade, string expected)
    {
        // Arrange

        // Act
        string actual = Grades.GradeAsWords(grade);

        // Assert
        Assert.AreEqual(expected, actual);
    }
}
