﻿using Xunit;
using testunit;

namespace SortingApp.Tests;

public class UnitTest1
{
    [Fact]
    public void Test_BubbleSort_SortsArrayCorrectly()
    {
        // Arrange
        var sortingApp = new SortingService();
        int[] inputArray = { 64, 34, 25, 12, 22, 11, 90 };
        int[] expectedArray = { 11, 12, 22, 25, 34, 64, 90 };

        // Act
        int[] result = sortingApp.BubbleSort(inputArray);

        // Assert
        Assert.Equal(expectedArray, result);
    }

    [Fact]
    public void Test_BubbleSort_SortsAlreadySortedArrayCorrectly()
    {
        // Arrange
        var sortingApp = new SortingService();
        int[] inputArray = { 11, 12, 22, 25, 34, 64, 90 };
        int[] expectedArray = { 11, 12, 22, 25, 34, 64, 90 };

        // Act
        int[] result = sortingApp.BubbleSort(inputArray);

        // Assert
        Assert.Equal(expectedArray, result);
    }

    [Fact]
    public void Test_BubbleSort_SortsArrayWithNegativeNumbersCorrectly()
    {
        // Arrange
        var sortingApp = new SortingService();
        int[] inputArray = { -64, 34, 25, -12, 22, 11, 90 };
        int[] expectedArray = { -64, -12, 11, 22, 25, 34, 90 };

        // Act
        int[] result = sortingApp.BubbleSort(inputArray);

        // Assert
        Assert.Equal(expectedArray, result);
    }

}
