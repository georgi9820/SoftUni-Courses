using NUnit.Framework;
using System;
using TestApp.Product;

namespace TestApp.Tests;

[TestFixture]
public class ProductInventoryTests
{
    private ProductInventory _inventory = null!;
    
    [SetUp]
    public void SetUp()
    {
        this._inventory = new();
    }
    
    [Test]
    public void Test_AddProduct_ProductAddedToInventory()
    {
        // Arrange
        string name = "bread";
        double price = 1.50;
        int quantity = 2;

        // Act
        this._inventory.AddProduct(name, price, quantity);

        // Assert
        string expectedInventoryDisplay = $"Product Inventory:{Environment.NewLine}{name} - Price: ${price:f2} - Quantity: {quantity}";
        Assert.AreEqual(expectedInventoryDisplay, this._inventory.DisplayInventory());
    }

    [Test]
    public void Test_DisplayInventory_NoProducts_ReturnsEmptyString()
    {

        // Act
        string result = this._inventory.DisplayInventory();

        // Assert
        Assert.That(result, Is.EqualTo("Product Inventory:"));
    }

    [Test]
    public void Test_DisplayInventory_WithProducts_ReturnsFormattedInventory()
    {
        // Arrange
        this._inventory.AddProduct("bread", 1.50, 2);
        this._inventory.AddProduct("milk", 2.00, 3);
        this._inventory.AddProduct("eggs", 0.75, 12);

        // Act
        string result = this._inventory.DisplayInventory();

        // Assert
        string expectedInventoryDisplay = "Product Inventory:" +
        $"{Environment.NewLine}bread - Price: $1.50 - Quantity: 2" +
        $"{Environment.NewLine}milk - Price: $2.00 - Quantity: 3" +
        $"{Environment.NewLine}eggs - Price: $0.75 - Quantity: 12";
        Assert.That(result , Is.EqualTo(expectedInventoryDisplay));
    }

    [Test]
    public void Test_CalculateTotalValue_NoProducts_ReturnsZero()
    {
        // Act
        double result = this._inventory.CalculateTotalValue();

        // Assert
        Assert.That(result, Is.EqualTo(0));
    }

    [Test]
    public void Test_CalculateTotalValue_WithProducts_ReturnsTotalValue()
    {
        // Arrange
        this._inventory.AddProduct("bread", 1.50, 2);
        this._inventory.AddProduct("milk", 2.00, 3);
        this._inventory.AddProduct("eggs", 0.75, 12);

        // Act
        double result = this._inventory.CalculateTotalValue();

        // Assert
        Assert.That(result, Is.EqualTo(18.00));
    }
}
