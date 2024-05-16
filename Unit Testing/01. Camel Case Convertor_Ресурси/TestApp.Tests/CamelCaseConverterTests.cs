using NUnit.Framework;

namespace TestApp.Tests;

[TestFixture]
public class CamelCaseConverterTests
{
    [Test]
    public void Test_ConvertToCamelCase_EmptyString_ReturnsEmptyString()
    {
        //Arrange
        string input = string.Empty;
        //Act
        string result = CamelCaseConverter.ConvertToCamelCase(input);
        //Assert
        Assert.That(result, Is.Empty);
    }

    [Test]
    public void Test_ConvertToCamelCase_SingleWord_ReturnsLowercaseWord()
    {
        //Arrange
        string input = "test";
        //Act
        string result = CamelCaseConverter.ConvertToCamelCase(input);
        //Assert
        Assert.That(result, Is.EqualTo("test"));
    }

    [Test]
    public void Test_ConvertToCamelCase_MultipleWords_ReturnsCamelCase()
    {
        //Arrange
        string input = "test period";
        //Act
        string result = CamelCaseConverter.ConvertToCamelCase(input);
        //Assert
        Assert.That(result, Is.EqualTo("testPeriod"));
    }

    [Test]
    public void Test_ConvertToCamelCase_MultipleWordsWithMixedCase_ReturnsCamelCase()
    {
        //Arrange
        string input = "SoftUni rocks";
        //Act
        string result = CamelCaseConverter.ConvertToCamelCase(input);
        //Assert
        Assert.That(result, Is.EqualTo("softuniRocks"));
    }
}
