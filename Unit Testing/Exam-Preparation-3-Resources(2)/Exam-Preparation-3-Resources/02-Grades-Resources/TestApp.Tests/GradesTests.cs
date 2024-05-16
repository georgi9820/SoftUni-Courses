using System;
using System.Collections.Generic;
using NUnit.Framework;

namespace TestApp.Tests;

[TestFixture]
public class GradesTests
{
    [Test]
    public void Test_GetBestStudents_ReturnsBestThreeStudents()
    {
        //Arrange
        Dictionary<string, int> grades = new Dictionary<string, int>() 
        {
            ["Robert"] = 5,
            ["Anna"] = 6,
            ["Denitsa"] = 4,
            ["George"] = 3
        };
        string expected = $"Anna with average grade 6.00{Environment.NewLine}Robert with average grade 5.00{Environment.NewLine}Denitsa with average grade 4.00";

        //Act
        string result = Grades.GetBestStudents(grades) ;

        //Assert
        Assert.AreEqual(expected, result);
    }

    [Test]
    public void Test_GetBestStudents_EmptyGrades_ReturnsEmptyString()
    {
        //Arrange
        Dictionary<string, int> grades = new Dictionary<string, int>();

        //Act
        string result = Grades.GetBestStudents(grades);

        //Assert
        Assert.That(result, Is.Empty);
    }

    [Test]
    public void Test_GetBestStudents_LessThanThreeStudents_ReturnsAllStudents()
    {
        //Arrange
        Dictionary<string, int> grades = new Dictionary<string, int>()
        {
            ["Robert"] = 5,
            ["Anna"] = 6
        };
        string expected = $"Anna with average grade 6.00{Environment.NewLine}Robert with average grade 5.00";

        //Act
        string result = Grades.GetBestStudents(grades);

        //Assert
        Assert.AreEqual(expected, result);
    }

    [Test]
    public void Test_GetBestStudents_SameGrade_ReturnsInAlphabeticalOrder()
    {
        //Arrange
        Dictionary<string, int> grades = new Dictionary<string, int>()
        {
            ["Anna"] = 4,
            ["Peter"] = 4,
            ["Denitsa"] = 4,
            ["Pepa"] = 4,
            ["Ferhunde"] = 4
        };
        string expected = $"Anna with average grade 4.00{Environment.NewLine}Denitsa with average grade 4.00{Environment.NewLine}Ferhunde with average grade 4.00";

        //Act
        string result = Grades.GetBestStudents(grades);

        //Assert
        Assert.AreEqual(expected, result);
    }
}
