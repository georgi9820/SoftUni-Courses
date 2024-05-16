using NUnit.Framework;

using System;
using System.Collections.Generic;

namespace TestApp.UnitTests;

public class ExceptionTests
{
    private Exceptions _exceptions = null!;

    [SetUp]
    public void SetUp()
    {
        this._exceptions = new();
    }

    // TODO: finish test
    [Test]
    public void Test_Reverse_ValidString_ReturnsReversedString()
    {
        // Arrange
        string input = "hello";
        string expected = "olleh";
        // Act
        string result = this._exceptions.ArgumentNullReverse(input);
        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    // TODO: finish test
    [Test]
    public void Test_Reverse_NullString_ThrowsArgumentNullException()
    {
        // Arrange
        string input = null;
        // Act & Assert
        Assert.That(() => this._exceptions.ArgumentNullReverse(input), Throws.ArgumentNullException);
    }

    [Test]
    public void Test_CalculateDiscount_ValidInput_ReturnsDiscountedPrice()
    {
        //Arrange
        decimal totalPrice = 100.0m;
        decimal discount = 10.0m;

        //Act
        decimal result = this._exceptions.ArgumentCalculateDiscount(totalPrice, discount);

        //Assert
        Assert.That(result, Is.EqualTo(90m));
    }

    // TODO: finish test
    [Test]
    public void Test_CalculateDiscount_NegativeDiscount_ThrowsArgumentException()
    {
        // Arrange
        decimal totalPrice = 100.0m;
        decimal discount = -10.0m;

        // Act & Assert
        Assert.That(() => this._exceptions.ArgumentCalculateDiscount(totalPrice, discount), Throws.ArgumentException);
    }

    // TODO: finish test
    [Test]
    public void Test_CalculateDiscount_DiscountOver100_ThrowsArgumentException()
    {
        // Arrange
        decimal totalPrice = 100.0m;
        decimal discount = 110.0m;

        // Act & Assert
        Assert.That(() => this._exceptions.ArgumentCalculateDiscount(totalPrice, discount), Throws.ArgumentException);
    }

    [Test]
    public void Test_GetElement_ValidIndex_ReturnsElement()
    {
        // Arrange
        int[] array = { 10, 20, 30, 40, 50 };
        int index = 2;

        //Act
        int result = this._exceptions.IndexOutOfRangeGetElement(array, index);

        //Assert
        Assert.That(result, Is.EqualTo(30));
    }

    // TODO: finish test
    [Test]
    public void Test_GetElement_IndexLessThanZero_ThrowsIndexOutOfRangeException()
    {
        // Arrange
        int[] array = { 10, 20, 30, 40, 50 };
        int index = -1;

        // Act & Assert
        Assert.That(() => this._exceptions.IndexOutOfRangeGetElement(array, index), Throws.InstanceOf<IndexOutOfRangeException>());
    }

    // TODO: finish test
    [Test]
    public void Test_GetElement_IndexEqualToArrayLength_ThrowsIndexOutOfRangeException()
    {
        // Arrange
        int[] array = { 10, 20, 30, 40, 50 };
        int index = array.Length;

        // Act & Assert
        Assert.That(() => this._exceptions.IndexOutOfRangeGetElement(array, index), Throws.InstanceOf<IndexOutOfRangeException>());
    }

    [Test]
    public void Test_GetElement_IndexGreaterThanArrayLength_ThrowsIndexOutOfRangeException()
    {
        // Arrange
        int[] array = { 10, 20, 30, 40, 50 };
        int index = 10;

        // Act & Assert
        Assert.That(() => this._exceptions.IndexOutOfRangeGetElement(array, index), Throws.InstanceOf<IndexOutOfRangeException>());
    }

    [Test]
    public void Test_PerformSecureOperation_UserLoggedIn_ReturnsUserLoggedInMessage()
    {
        //Arrange
        bool isLoggedIn = true;

        //Act
        string result = this._exceptions.InvalidOperationPerformSecureOperation(isLoggedIn);

        //Assert
        Assert.That(result, Is.EqualTo("User logged in."));
    }

    [Test]
    public void Test_PerformSecureOperation_UserNotLoggedIn_ThrowsInvalidOperationException()
    {
        //Arrange
        bool isLoggedIn = false;

        //Act & Assert
        Assert.That(() => this._exceptions.InvalidOperationPerformSecureOperation(isLoggedIn), Throws.InstanceOf<InvalidOperationException>());
    }

    [Test]
    public void Test_ParseInt_ValidInput_ReturnsParsedInteger()
    {
        //Arrange
        string input = "69";

        //Act
        int result = this._exceptions.FormatExceptionParseInt(input);

        //Assert
        Assert.That(result, Is.EqualTo(69));
    }

    [Test]
    public void Test_ParseInt_InvalidInput_ThrowsFormatException()
    {
        //Arrange
        string input = "Hello";

        //Act & Assert
        Assert.That(() => this._exceptions.FormatExceptionParseInt(input), Throws.InstanceOf<FormatException>());
    }

    [Test]
    public void Test_FindValueByKey_KeyExistsInDictionary_ReturnsValue()
    {
        //Arrange
        Dictionary<string, int> values = new Dictionary<string, int>()
        {
            ["first"] = 1,
            ["second"] = 2,
            ["third"] = 3,
        };
        string key = "second";

        //Act
        int result = this._exceptions.KeyNotFoundFindValueByKey(values, key);

        //Assert
        Assert.That(result, Is.EqualTo(2));
    }

    [Test]
    public void Test_FindValueByKey_KeyDoesNotExistInDictionary_ThrowsKeyNotFoundException()
    {
        //Arrange
        Dictionary<string, int> values = new Dictionary<string, int>()
        {
            ["first"] = 1,
            ["second"] = 2,
            ["third"] = 3,
        };
        string key = "four";

        //Act & Assert
        Assert.That(() => this._exceptions.KeyNotFoundFindValueByKey(values, key), Throws.InstanceOf<KeyNotFoundException>());
    }

    [Test]
    public void Test_AddNumbers_NoOverflow_ReturnsSum()
    {
        //Arrange
        int a = 2;
        int b = 3;

        //Act
        int result = this._exceptions.OverflowAddNumbers(a, b);

        //Assert
        Assert.That(result, Is.EqualTo(5));
    }

    [Test]
    public void Test_AddNumbers_PositiveOverflow_ThrowsOverflowException()
    {
        //Arrange
        int a = int.MaxValue;
        int b = 3;

        //Act & Assert
        Assert.That(() => this._exceptions.OverflowAddNumbers(a, b), Throws.InstanceOf<OverflowException>());
    }

    [Test]
    public void Test_AddNumbers_NegativeOverflow_ThrowsOverflowException()
    {
        //Arrange
        int a = int.MinValue;
        int b = -3;

        //Act & Assert
        Assert.That(() => this._exceptions.OverflowAddNumbers(a, b), Throws.InstanceOf<OverflowException>());
    }

    [Test]
    public void Test_DivideNumbers_ValidDivision_ReturnsQuotient()
    {
        //Arrange
        int divined = 4;
        int divisor = 2;

        //Act
        int result = this._exceptions.DivideByZeroDivideNumbers(divined, divisor);

        //Assert
        Assert.That(result, Is.EqualTo(2));
    }

    [Test]
    public void Test_DivideNumbers_DivideByZero_ThrowsDivideByZeroException()
    {
        //Arrange
        int divined = 4;
        int divisor = 0;

        //Act & Assert
        Assert.That(() => this._exceptions.DivideByZeroDivideNumbers(divined, divisor), Throws.InstanceOf<DivideByZeroException>());
    }

    [Test]
    public void Test_SumCollectionElements_ValidCollectionAndIndex_ReturnsSum()
    {
        //Arrange
        int[] collection = new int[] { 1, 2, 3, 4 };
        int index = 2;

        //Act
        int result = this._exceptions.SumCollectionElements(collection, index);

        //Assert
        Assert.That(result, Is.EqualTo(10));
    }

    [Test]
    public void Test_SumCollectionElements_NullCollection_ThrowsArgumentNullException()
    {
        //Arrange
        int[]? collection = null;
        int index = 2;

        //Act & Assert
        Assert.That(() => this._exceptions.SumCollectionElements(collection, index), Throws.ArgumentNullException);
    }

    [Test]
    public void Test_SumCollectionElements_IndexOutOfRange_ThrowsIndexOutOfRangeException()
    {
        //Arrange
        int[]? collection = new int[] { 1, 2, 3, 4 };
        int index = 6;

        //Act & Assert
        Assert.That(() => this._exceptions.SumCollectionElements(collection, index), Throws.InstanceOf<IndexOutOfRangeException>());
    }

    [Test]
    public void Test_GetElementAsNumber_ValidKey_ReturnsParsedNumber()
    {
        //Arrange
        Dictionary<string, string> elements = new()
        {
            ["first"] = "1",
            ["second"] = "2",
            ["third"] = "3"
        };
        string index = "second";

        //Act
        int result = this._exceptions.GetElementAsNumber(elements, index);

        //Assert
        Assert.That(result, Is.EqualTo(2));
    }

    [Test]
    public void Test_GetElementAsNumber_KeyNotFound_ThrowsKeyNotFoundException()
    {
        //Arrange
        Dictionary<string, string> elements = new()
        {
            ["first"] = "1",
            ["second"] = "2",
            ["third"] = "3"
        };
        string index = "four";

        //Act & Assert
        Assert.That(() => this._exceptions.GetElementAsNumber(elements, index), Throws.InstanceOf<KeyNotFoundException>());
    }

    [Test]
    public void Test_GetElementAsNumber_InvalidFormat_ThrowsFormatException()
    {
        //Arrange
        Dictionary<string, string> elements = new()
        {
            ["first"] = "1",
            ["second"] = "2",
            ["third"] = "three"
        };
        string index = "third";

        //Act & Assert
        Assert.That(() => this._exceptions.GetElementAsNumber(elements, index), Throws.InstanceOf<FormatException>());
    }
}
