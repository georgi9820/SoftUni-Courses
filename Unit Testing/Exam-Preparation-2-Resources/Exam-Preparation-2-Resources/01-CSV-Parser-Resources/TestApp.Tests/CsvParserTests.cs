using NUnit.Framework;

namespace TestApp.Tests;

[TestFixture]
public class CsvParserTests
{
    [Test]
    public void Test_ParseCsv_EmptyInput_ReturnsEmptyArray()
    {
        //Arrange
        string data = string.Empty;

        //Act
        string[] result = CsvParser.ParseCsv(data);

        //Assert
        Assert.That(result, Is.Empty);
    }

    [Test]
    public void Test_ParseCsv_SingleField_ReturnsArrayWithOneElement()
    {
        //Arrange
        string data = "java";

        string[] expected = new[] { "java" };
        //Act
        string[] result = CsvParser.ParseCsv(data);

        //Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_ParseCsv_MultipleFields_ReturnsArrayWithMultipleElements()
    {
        //Arrange
        string data = "java,c#,python";

        string[] expected = new[] { "java", "c#", "python" };
        //Act
        string[] result = CsvParser.ParseCsv(data);

        //Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_ParseCsv_TrimsWhiteSpace_ReturnsCleanArray()
    {
        //Arrange
        string data = "java, c#, python";

        string[] expected = new[] { "java", "c#", "python" };
        //Act
        string[] result = CsvParser.ParseCsv(data);

        //Assert
        Assert.That(result, Is.EqualTo(expected));
    }
}
