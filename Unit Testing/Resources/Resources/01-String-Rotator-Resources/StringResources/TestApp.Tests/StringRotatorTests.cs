using NUnit.Framework;

namespace TestApp.Tests;

[TestFixture]
public class StringRotatorTests
{
    [Test]
    public void Test_RotateRight_EmptyString_ReturnsEmptyString()
    {
        //Arrange
        string input = string.Empty;
        int positions = 2;

        //Act
        string result = StringRotator.RotateRight(input, positions);

        //Assert
        Assert.That(result, Is.Empty);
    }

    [Test]
    public void Test_RotateRight_RotateByZeroPositions_ReturnsOriginalString()
    {
        //Arrange
        string input = "hello";
        int positions = 0;

        //Act
        string result = StringRotator.RotateRight(input, positions);

        //Assert
        Assert.That(result, Is.EqualTo("hello"));
    }

    [Test]
    public void Test_RotateRight_RotateByPositivePositions_ReturnsRotatedString()
    {
        //Arrange
        string input = "abcdef";
        int positions = 2;

        //Act
        string result = StringRotator.RotateRight(input, positions);

        //Assert
        Assert.That(result, Is.EqualTo("efabcd"));
    }

    [Test]
    public void Test_RotateRight_RotateByNegativePositions_ReturnsRotatedString()
    {
        //Arrange
        string input = "12345";
        int positions = -2;

        //Act
        string result = StringRotator.RotateRight(input, positions);

        //Assert
        Assert.That(result, Is.EqualTo("45123"));
    }

    [Test]
    public void Test_RotateRight_RotateByMorePositionsThanStringLength_ReturnsRotatedString()
    {
        //Arrange
        string input = "xyz";
        int positions = 5;

        //Act
        string result = StringRotator.RotateRight(input, positions);

        //Assert
        Assert.That(result, Is.EqualTo("yzx"));
    }
}
