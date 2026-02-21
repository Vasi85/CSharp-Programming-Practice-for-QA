using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace TestApp.UnitTests;

public class SortingTests
{
    [Test]
    public void Test_ShallowAscendingSort_EmptyArrayParameter_ReturnsEmptyArray()
    {
        // Arrange
        double[] emptyArray = Array.Empty<double>();

        // Act
        double[] result = Sorting.ShallowAscendingSort(emptyArray);

        // Assert
        CollectionAssert.AreEqual(emptyArray, result);
    }

    [Test]
    public void Test_DeepAscendingSort_EmptyArrayParameter_ReturnsEmptyArray()
    {
        // Arrange
        double[] emptyArray = Array.Empty<double>();

        // Act
        double[] result = Sorting.DeepAscendingSort(emptyArray);

        // Assert
        CollectionAssert.AreEqual(emptyArray, result);
    }

    [Test]
    public void Test_ShallowAscendingSort_UnOrderedArrayParam_ReturnsAscendingOrderedArrayAndDoesNotChangeTheOriginalArray()
    {
        // Arrange
        double[] orderedArrayParam = new double[] { 3, 2, 1 };
        double[] expected = new double[] { 1, 2, 3 };

        // Act
        double[] result = Sorting.ShallowAscendingSort(orderedArrayParam);

        // Assert
        CollectionAssert.AreEqual(expected, result);
    }

    [Test]
    public void Test_DeepAscendingSort_UnOrderedArrayParam_ReturnsAscendingOrderedArrayAndDoesChangeTheOriginalArray()
    {
        // Arrange
        double[] orderedArrayParam = new double[] { 3, 2, 1 };
        double[] expected = new double[] { 1, 2, 3 };

        // Act
        double[] result = Sorting.DeepAscendingSort(orderedArrayParam);

        // Assert
        CollectionAssert.AreEqual(expected, result);
    }
}
