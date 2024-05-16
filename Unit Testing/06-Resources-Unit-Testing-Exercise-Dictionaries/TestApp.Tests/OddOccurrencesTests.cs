using NUnit.Framework;

using System;
using System.Collections.Generic;

namespace TestApp.Tests;

public class OddOccurrencesTests
{
    [Test]
    public void Test_FindOdd_WithEmptyArray_ShouldReturnEmptyString()
    {
        // Arrange
        string[] input = Array.Empty<string>();

        // Act
        string result = OddOccurrences.FindOdd(input);

        // Assert
        Assert.That(result, Is.Empty);
    }

    // TODO: finish test
    [Test]
    public void Test_FindOdd_WithNoOddOccurrences_ShouldReturnEmptyString()
    {
        // Arrange
        string[] input = new string[] { "the", "the" };

        // Act
        string result = OddOccurrences.FindOdd(input);

        // Assert
        Assert.That(result, Is.Empty);
    }

    [Test]
    public void Test_FindOdd_WithSingleOddOccurrence_ShouldReturnTheOddWord()
    {
        // Arrange
        string[] input = new string[] { "the", "the", "the" };

        // Act
        string result = OddOccurrences.FindOdd(input);

        // Assert
        Assert.That(result, Is.EqualTo("the"));
    }

    [Test]
    public void Test_FindOdd_WithMultipleOddOccurrences_ShouldReturnAllOddWords()
    {
        // Arrange
        string[] input = new string[] { "the", "on", "on", "the", "the", "on" };

        // Act
        string result = OddOccurrences.FindOdd(input);

        // Assert
        Assert.That(result, Is.EqualTo("the on"));
    }

    [Test]
    public void Test_FindOdd_WithMixedCaseWords_ShouldBeCaseInsensitive()
    {
        // Arrange
        string[] input = new string[] { "tHe", "On", "on", "The", "the", "ON" };

        // Act
        string result = OddOccurrences.FindOdd(input);

        // Assert
        Assert.That(result, Is.EqualTo("the on"));
    }
}
