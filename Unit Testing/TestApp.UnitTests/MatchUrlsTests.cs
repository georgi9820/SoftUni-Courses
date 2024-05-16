using NUnit.Framework;

using System.Collections.Generic;

namespace TestApp.UnitTests;

public class MatchUrlsTests
{
    // TODO: finish the test
    [Test]
    public void Test_ExtractUrls_EmptyText_ReturnsEmptyList()
    {
        // Arrange
        string text = "";

        // Act
        var result = MatchUrls.ExtractUrls(text);

        // Assert
        CollectionAssert.IsEmpty(result);
    }

    // TODO: finish the test
    [Test]
    public void Test_ExtractUrls_NoUrlsInText_ReturnsEmptyList()
    {
        // Arrange
        string text = "Some text";

        // Act
        var result = MatchUrls.ExtractUrls(text);

        // Assert
        CollectionAssert.IsEmpty(result);
        //Assert.That(result, Is.Empty);
    }

    [Test]
    public void Test_ExtractUrls_SingleUrlInText_ReturnsSingleUrl()
    {
        // Arrange
        string text = "Single URL: https://softuni.bg";
        List<string> expected = new List<string> { "https://softuni.bg" };

        // Act
        var result = MatchUrls.ExtractUrls(text);

        // Assert
        CollectionAssert.AreEqual(result, expected);
    }

    [Test]
    public void Test_ExtractUrls_MultipleUrlsInText_ReturnsAllUrls()
    {
        // Arrange
        string text = "First URL: https://softuni.bg, Second URL: https://gplay.bg";
        List<string> expected = new List<string> { "https://softuni.bg", "https://gplay.bg" };

        // Act
        var result = MatchUrls.ExtractUrls(text);

        // Assert
        CollectionAssert.AreEqual(result, expected);
    }

    [Test]
    public void Test_ExtractUrls_UrlsInQuotationMarks_ReturnsUrlsInQuotationMarks()
    {
        // Arrange
        string text = "First URL: \"https://gplay.bg\"";
        List<string> expected = new List<string> { "https://gplay.bg" };

        // Act
        var result = MatchUrls.ExtractUrls(text);

        // Assert
        CollectionAssert.AreEqual(result, expected);
    }
}
