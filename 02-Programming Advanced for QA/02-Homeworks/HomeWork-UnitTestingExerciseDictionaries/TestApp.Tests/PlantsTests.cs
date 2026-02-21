using NUnit.Framework;

using System;

namespace TestApp.Tests;

public class PlantsTests
{
    [Test]
    public void Test_GetFastestGrowing_WithEmptyArray_ShouldReturnEmptyString()
    {
        // Arrange
        string[] plants = Array.Empty<string>();

        // Act
        string result = Plants.GetFastestGrowing(plants);

        // Assert
        Assert.That(result, Is.Empty);
    }

    [Test]
    public void Test_GetFastestGrowing_WithSinglePlant_ShouldReturnPlant()
    {
        // Arrange
        string[] plants = new string[] { "palm" };
        string expected = "Plants with 4 letters:" + Environment.NewLine + 
                          "palm";

        // Act
        string result = Plants.GetFastestGrowing(plants);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_GetFastestGrowing_WithMultiplePlants_ShouldReturnGroupedPlants()
    {
        // Arrange
        string[] plants = new string[] { "palm", "orchid", "amaryllis" };
        string expected = "Plants with 4 letters:" + Environment.NewLine +
                          "palm" + Environment.NewLine +
                          "Plants with 6 letters:" + Environment.NewLine +
                          "orchid" + Environment.NewLine +
                          "Plants with 9 letters:" + Environment.NewLine +
                          "amaryllis";

        // Act
        string result = Plants.GetFastestGrowing(plants);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_GetFastestGrowing_WithMixedCasePlants_ShouldBeCaseInsensitive()
    {
        // Arrange
        string[] plants = new string[] { "PALM", "orCHid", "Amaryllis" };
        string expected = "Plants with 4 letters:" + Environment.NewLine +
                          "PALM" + Environment.NewLine +
                          "Plants with 6 letters:" + Environment.NewLine +
                          "orCHid" + Environment.NewLine +
                          "Plants with 9 letters:" + Environment.NewLine +
                          "Amaryllis";

        // Act
        string result = Plants.GetFastestGrowing(plants);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }
}
