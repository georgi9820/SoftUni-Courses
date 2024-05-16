using System.Collections.Generic;

using NUnit.Framework;

namespace TestApp.Tests;

[TestFixture]
public class FruitsTests
{
    [Test]
    public void Test_GetFruitQuantity_FruitExists_ReturnsQuantity()
    {
        //Arrange
        Dictionary<string, int> fruits = new Dictionary<string, int>() 
        {
            ["apple"] = 30,
            ["banana"] = 45,
            ["pineapple"] = 8
        };
        string fruitName = "pineapple";

        //Act
        int result = Fruits.GetFruitQuantity(fruits, fruitName);

        //Assert
        Assert.That(result, Is.EqualTo(8));
    }

    [Test]
    public void Test_GetFruitQuantity_FruitDoesNotExist_ReturnsZero()
    {
        //Arrange
        Dictionary<string, int> fruits = new Dictionary<string, int>()
        {
            ["apple"] = 30,
            ["banana"] = 45,
            ["pineapple"] = 8
        };
        string fruitName = "peach";

        //Act
        int result = Fruits.GetFruitQuantity(fruits, fruitName);

        //Assert
        Assert.That(result, Is.EqualTo(0));
    }

    [Test]
    public void Test_GetFruitQuantity_EmptyDictionary_ReturnsZero()
    {
        //Arrange
        Dictionary<string, int> fruits = new Dictionary<string, int>()
        {
            
        };
        string fruitName = "peach";

        //Act
        int result = Fruits.GetFruitQuantity(fruits, fruitName);

        //Assert
        Assert.That(result, Is.EqualTo(0));
    }

    [Test]
    public void Test_GetFruitQuantity_NullDictionary_ReturnsZero()
    {
        //Arrange
        Dictionary<string, int>? fruits = null;
        string fruitName = "peach";

        //Act
        int result = Fruits.GetFruitQuantity(fruits, fruitName);

        //Assert
        Assert.That(result, Is.EqualTo(0));
    }

    [Test]
    public void Test_GetFruitQuantity_NullFruitName_ReturnsZero()
    {
        //Arrange
        Dictionary<string, int> fruits = new Dictionary<string, int>()
        {
            ["apple"] = 30,
            ["banana"] = 45,
            ["pineapple"] = 8
        };
        string? fruitName = null;

        //Act
        int result = Fruits.GetFruitQuantity(fruits, fruitName);

        //Assert
        Assert.That(result, Is.EqualTo(0));
    }
}
