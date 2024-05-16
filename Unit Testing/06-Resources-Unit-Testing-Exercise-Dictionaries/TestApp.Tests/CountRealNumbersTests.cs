using NUnit.Framework;

using System;
using System.Text;

namespace TestApp.Tests;

public class CountRealNumbersTests
{
    // TODO: finish test
    [Test]
    public void Test_Count_WithEmptyArray_ShouldReturnEmptyString()
    {
        // Arrange
        int[] nums = Array.Empty<int>(); 


        // Act
        string result = CountRealNumbers.Count(nums);

        // Assert
        Assert.That(result, Is.Empty);
    }

    [Test]
    public void Test_Count_WithSingleNumber_ShouldReturnCountString()
    {
        // Arrange
        int[] nums = new int[] { 7 };

        // Act
        string result = CountRealNumbers.Count(nums);

        // Assert
        Assert.That(result, Is.EqualTo("7 -> 1"));
    }

    [Test]
    public void Test_Count_WithMultipleNumbers_ShouldReturnCountString()
    {
        // Arrange
        int[] nums = new int[] { 6, 2, 6, 4, 2, 6 };
        StringBuilder sb = new StringBuilder();
        sb.AppendLine("2 -> 2");
        sb.AppendLine("4 -> 1");
        sb.AppendLine("6 -> 3");
        string expected = sb.ToString().Trim();
        // Act
        string result = CountRealNumbers.Count(nums);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_Count_WithNegativeNumbers_ShouldReturnCountString()
    {
        // Arrange
        int[] nums = new int[] { -6, -2, -6, -4, -2, -6 };
        StringBuilder sb = new StringBuilder();
        sb.AppendLine("-6 -> 3");
        sb.AppendLine("-4 -> 1");
        sb.AppendLine("-2 -> 2");
        string expected = sb.ToString().Trim();
        // Act
        string result = CountRealNumbers.Count(nums);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_Count_WithZero_ShouldReturnCountString()
    {
        // Arrange
        int[] nums = new int[] { 0 };
        
        // Act
        string result = CountRealNumbers.Count(nums);

        // Assert
        Assert.That(result, Is.EqualTo("0 -> 1"));
    }
}
