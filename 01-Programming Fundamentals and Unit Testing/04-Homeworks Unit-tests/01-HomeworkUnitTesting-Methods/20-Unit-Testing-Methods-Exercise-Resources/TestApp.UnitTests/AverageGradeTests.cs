using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace TestApp.UnitTests;

public class AverageGradeTests
{
    [TestCase(new double[] { 0.7, 0.0, 0.9 })]
    [TestCase(new double[] { 1.9, 2, 1.0 })]
    [TestCase(new double[] { -1.05, 2.5, -1 })]
    public void Test_GetGradeDefinition_AverageGradeUnderTwo_ReturnsErrorMessage(double[] grade)
    {
        // Arrange
        List<double> doubleGrade = grade.ToList();
        string expected = "Incorrect grades";

        // Act
        string result = AverageGrade.GetGradeDefinition(doubleGrade);

        // Assert
        Assert.AreEqual(expected, result);
    }

    [TestCase(new double[] { 6.7, 6.0, 6.9 })]
    [TestCase(new double[] { 7.09, -7.15, 1.0 })]
    [TestCase(new double[] { -7.05, 7.5, -7.01 })]
    public void Test_GetGradeDefinition_AverageGradeOverSix_ReturnsErrorMessage(double[] grade)
    {
        // Arrange
        List<double> doubleGrade = grade.ToList();
        string expected = "Incorrect grades";

        // Act
        string result = AverageGrade.GetGradeDefinition(doubleGrade);

        // Assert
        Assert.AreEqual(expected, result);
    }

    [TestCase(new double[] { 2.7, 2.0, 2.9 })]
    [TestCase(new double[] { 2.00, 2.40, 2.00 })]
    [TestCase(new double[] { 2.95, 2.99, 2.99 })]
    public void Test_GetGradeDefinition_FailScoreAverageGrade_ReturnsFailDefinitionMessage(double[] grade)
    {
        // Arrange
        List<double> doubleGrade = grade.ToList();
        string expected = "Fail";

        // Act
        string result = AverageGrade.GetGradeDefinition(doubleGrade);

        // Assert
        Assert.AreEqual(expected, result);
    }

    [TestCase(new double[] { 3.00, 3.00, 3.00 })]
    [TestCase(new double[] { 3.30, 3.10, 3.45 })]
    [TestCase(new double[] { 3.49, 3.49, 3.49 })]
    public void Test_GetGradeDefinition_PoorScoreAverageGrade_ReturnsPoorDefinitionMessage(double[] grade)
    {
        // Arrange
        List<double> doubleGrade = grade.ToList();
        string expected = "Poor";

        // Act
        string result = AverageGrade.GetGradeDefinition(doubleGrade);

        // Assert
        Assert.AreEqual(expected, result);
    }

    [TestCase(new double[] { 3.50, 3.52, 3.50 })]
    [TestCase(new double[] { 4.30, 3.90, 4.45 })]
    [TestCase(new double[] { 4.49, 4.49, 4.49 })]
    public void Test_GetGradeDefinition_GoodScoreAverageGrade_ReturnsGoodDefinitionMessage(double[] grade)
    {
        // Arrange
        List<double> doubleGrade = grade.ToList();
        string expected = "Good";

        // Act
        string result = AverageGrade.GetGradeDefinition(doubleGrade);

        // Assert
        Assert.AreEqual(expected, result);
    }

    [TestCase(new double[] { 4.50, 4.52, 4.50 })]
    [TestCase(new double[] { 5.30, 4.90, 5.45 })]
    [TestCase(new double[] { 5.49, 5.49, 5.49 })]
    public void Test_GetGradeDefinition_VeryGoodScoreAverageGrade_ReturnsVeryGoodDefinitionMessage(double[] grade)
    {
        // Arrange
        List<double> doubleGrade = grade.ToList();
        string expected = "Very good";

        // Act
        string result = AverageGrade.GetGradeDefinition(doubleGrade);

        // Assert
        Assert.AreEqual(expected, result);
    }

    [TestCase(new double[] { 5.50, 5.52, 5.50 })]
    [TestCase(new double[] { 5.30, 5.90, 5.75 })]
    [TestCase(new double[] { 6.00, 6.00, 6.00 })]
    public void Test_GetGradeDefinition_ExcellentScoreAverageGrade_ReturnsExcellentDefinitionMessage(double[] grade)
    {
        // Arrange
        List<double> doubleGrade = grade.ToList();
        string expected = "Excellent";

        // Act
        string result = AverageGrade.GetGradeDefinition(doubleGrade);

        // Assert
        Assert.AreEqual(expected, result);
    }
}
