using System;
using NUnit.Framework;

namespace TestApp.Tests;

public class OrdersTests
{
    [Test]
    public void Test_Order_WithEmptyInput_ShouldReturnEmptyString()
    {
        // Arrange
        string[] input = Array.Empty<string>();
        // Act
        string result = Orders.Order(input);

        // Assert
        Assert.That(result, Is.Empty);
    }

    // TODO: finish test
    [Test]
    public void Test_Order_WithMultipleOrders_ShouldReturnTotalPrice()
    {
        // Arrange
        string[] input = new string[] { "apple 1.85 2", "banana 3.49 3", "orange 2.45 8"};
        // Act
        string result = Orders.Order(input);

        // Assert
        Assert.That(result, Is.EqualTo($"apple -> 3.70{Environment.NewLine}banana -> 10.47{Environment.NewLine}orange -> 19.60"));
    }

    [Test]
    public void Test_Order_WithRoundedPrices_ShouldReturnTotalPrice()
    {
        // Arrange
        string[] input = new string[] { "apple 1.85000 2", "banana 3.490000 3", "orange 2.4500000 8" };
        // Act
        string result = Orders.Order(input);

        // Assert
        Assert.That(result, Is.EqualTo($"apple -> 3.70{Environment.NewLine}banana -> 10.47{Environment.NewLine}orange -> 19.60"));
    }

    [Test]
    public void Test_Order_WithDecimalQuantities_ShouldReturnTotalPrice()
    {
        // Arrange
        string[] input = new string[] { 
            "apple 2.00 4.5", 
            "banana 3.00 2.5", 
            "orange 1.50 3.5" 
        };
        // Act
        string result = Orders.Order(input);

        // Assert
        Assert.That(result, Is.EqualTo($"apple -> 9.00{Environment.NewLine}banana -> 7.50{Environment.NewLine}orange -> 5.25"));
    }
}
