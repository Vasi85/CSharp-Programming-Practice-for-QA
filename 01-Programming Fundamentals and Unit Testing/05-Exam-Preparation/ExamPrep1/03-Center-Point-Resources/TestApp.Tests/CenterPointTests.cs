using System;
using NUnit.Framework;

namespace TestApp.Tests;

public class CenterPointTests
{
    [Test]
    public void Test_GetClosest_WhenFirstPointIsCloser_ShouldReturnFirstPoint()
    {
        //Arrange
        string expected = "(1, 1)";

        //Act
        var actual = CenterPoint.GetClosest( 1, 1, 2, 2 );

        //Assert
        CollectionAssert.AreEqual(actual, expected);
    }

    [Test]
    public void Test_GetClosest_WhenSecondPointIsCloser_ShouldReturnSecondPoint()
    {
        string expected = "(1, 1)";

        //Act
        var actual = CenterPoint.GetClosest(2, 2, 1, 1);

        //Assert
        CollectionAssert.AreEqual(actual, expected);
    }

    [Test]
    public void Test_GetClosest_WhenBothPointsHaveEqualDistance_ShouldReturnFirstPoint()
    {
        string expected = "(2, 2)";

        //Act
        var actual = CenterPoint.GetClosest(2, 2, 2, 2);

        //Assert
        CollectionAssert.AreEqual(actual, expected);
    }

    [Test]
    public void Test_GetClosest_WhenFirstPointIsNegative_ShouldReturnFirstPoint()
    {
        string expected = "(-2, -2)";

        //Act
        var actual = CenterPoint.GetClosest(-2, -2, 2, 2);

        //Assert
        CollectionAssert.AreEqual(actual, expected);
    }

    [Test]
    public void Test_GetClosest_WhenSecondPointIsNegative_ShouldReturnSecondPoint()
    {
        string expected = "(-2, -2)";

        //Act
        var actual = CenterPoint.GetClosest(2, 2, -2, -2);

        //Assert
        CollectionAssert.AreEqual(actual, expected);
    }
}
