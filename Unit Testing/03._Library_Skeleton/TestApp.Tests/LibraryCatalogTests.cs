using NUnit.Framework;
using System;
using TestApp.Library;

namespace TestApp.Tests;

[TestFixture]
public class LibraryCatalogTests
{
    private LibraryCatalog _catalog = null!;

    [SetUp]
    public void SetUp()
    {
        this._catalog = new();
    }

    [Test]
    public void Test_AddBook_BookAddedToCatalog()
    {
        
        string isbn = "978-954-398-527-3";
        string title = "Zaspalata Krastavica";
        string author = "Baba Yaga";
        
        this._catalog.AddBook(isbn, title, author);

        string result = this._catalog.DisplayCatalog();

        string expected = $"Library Catalog:{Environment.NewLine}Zaspalata Krastavica by Baba Yaga (ISBN: 978-954-398-527-3)";

        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_GetBook_BookExists_ReturnsBook()
    {
        string isbn = "978-954-398-527-3";
        string title = "Zaspalata Krastavica";
        string author = "Baba Yaga";

        this._catalog.AddBook(isbn, title, author);

        Book result = this._catalog.GetBook(isbn);

        Assert.That(result.Isbn, Is.EqualTo(isbn));
        Assert.That(result.Title, Is.EqualTo(title));
        Assert.That(result.Author, Is.EqualTo(author));
    }

    [Test]
    public void Test_GetBook_BookDoesNotExist_ThrowsArgumentException()
    {
        string isbn = "978-954-398-527-3";
        string title = "Zaspalata Krastavica";
        string author = "Baba Yaga";

        this._catalog.AddBook(isbn, title, author);

        Assert.Throws<ArgumentException>(() => this._catalog.GetBook("69-69-69"));
    }

    [Test]
    public void Test_DisplayCatalog_NoBooks_ReturnsEmptyString()
    {
        string result = this._catalog.DisplayCatalog();

        Assert.That(result, Is.Empty);
    }

    [Test]
    public void Test_DisplayCatalog_WithBooks_ReturnsFormattedCatalog()
    {
        // Arrange
        string isbn1 = "978-954-398-527-3";
        string title1 = "Zaspalata Krastavica";
        string author1 = "Baba Yaga";

        string isbn2 = "978-1-234-56789-0";
        string title2 = "Stanimujki Sarmi";
        string author2 = "Bai Sasho";

        this._catalog.AddBook(isbn1, title1, author1);
        this._catalog.AddBook(isbn2, title2, author2);

        // Act
        string result = this._catalog.DisplayCatalog();

        // Assert
        string expected = $"Library Catalog:{Environment.NewLine}" +
                          $"Zaspalata Krastavica by Baba Yaga (ISBN: 978-954-398-527-3){Environment.NewLine}" +
                          $"Stanimujki Sarmi by Bai Sasho (ISBN: 978-1-234-56789-0)";

        Assert.That(result, Is.EqualTo(expected));
    }
}
