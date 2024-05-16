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
        Dictionary<string, int> keyValuePairs = new Dictionary<string, int>();
        keyValuePairs.Add("Anton", 6);
        keyValuePairs.Add("Petyr", 6);
        keyValuePairs.Add("Nikoleta", 4);
        keyValuePairs.Add("Ivan", 4);
        keyValuePairs.Add("Mariyka", 2);
        keyValuePairs.Add("Katya", 5);

        string result = Grades.GetBestStudents(keyValuePairs);
        string expected = $"Anton with average grade 6.00{Environment.NewLine}Petyr with average grade 6.00" +
            $"{Environment.NewLine}Katya with average grade 5.00";

        Assert.AreEqual(expected, result);

    }

    [Test]
    public void Test_GetBestStudents_EmptyGrades_ReturnsEmptyString()
    {
        Dictionary<string, int> keyValuePairs = new Dictionary<string, int>();

        string result = Grades.GetBestStudents(keyValuePairs);
        string expected = string.Empty;

        Assert.AreEqual(expected, result);
    }

    [Test]
    public void Test_GetBestStudents_LessThanThreeStudents_ReturnsAllStudents()
    {
        Dictionary<string, int> keyValuePairs = new Dictionary<string, int>();
        keyValuePairs.Add("Mariyka", 2);
        keyValuePairs.Add("Katya", 5);

        string result = Grades.GetBestStudents(keyValuePairs);
        string expected = $"Katya with average grade 5.00{Environment.NewLine}Mariyka with average grade 2.00";
        Assert.AreEqual(expected, result);
    }

    [Test]
    public void Test_GetBestStudents_SameGrade_ReturnsInAlphabeticalOrder()
    {
        Dictionary<string, int> keyValuePairs = new Dictionary<string, int>();
        keyValuePairs.Add("Anton", 6);
        keyValuePairs.Add("Petyr", 6);
        keyValuePairs.Add("Nikoleta", 6);
        keyValuePairs.Add("Ivan", 6);
        keyValuePairs.Add("Mariyka", 6);
        keyValuePairs.Add("Katya", 6);

        string result = Grades.GetBestStudents(keyValuePairs);

        string expected = $"Anton with average grade 6.00{Environment.NewLine}Ivan with average grade 6.00" +
            $"{Environment.NewLine}Katya with average grade 6.00";
        
        Assert.AreEqual(expected, result);
    }
}
