using System.Collections.Generic;

using NUnit.Framework;

namespace TestApp.Tests;

[TestFixture]
public class DictionaryIntersectionTests
{
    [Test]
    public void Test_Intersect_TwoEmptyDictionaries_ReturnsEmptyDictionary()
    {
        //Arrange
        Dictionary<string, int> dict1 = new Dictionary<string, int>();
        Dictionary<string, int> dict2 = new Dictionary<string, int>();

        //Act
        Dictionary<string, int> result = DictionaryIntersection.Intersect(dict1, dict2);

        //Assert
        Assert.That(result, Is.Empty);
    }

    [Test]
    public void Test_Intersect_OneEmptyDictionaryAndOneNonEmptyDictionary_ReturnsEmptyDictionary()
    {
        //Arrange
        Dictionary<string, int> dict1 = new Dictionary<string, int>();
        Dictionary<string, int> dict2 = new Dictionary<string, int>()
        {
            ["first"] = 1,
            ["second"] = 2,
            ["third"] = 3
        };

        //Act
        Dictionary<string, int> result = DictionaryIntersection.Intersect(dict1, dict2);

        //Assert
        Assert.That(result, Is.Empty);
    }

    [Test]
    public void Test_Intersect_TwoNonEmptyDictionariesWithNoCommonKeys_ReturnsEmptyDictionary()
    {
        //Arrange
        Dictionary<string, int> dict1 = new Dictionary<string, int>()
        {
            ["four"] = 4,
            ["fifth"] = 5,
            ["sixth"] = 6
        };
        Dictionary<string, int> dict2 = new Dictionary<string, int>()
        {
            ["first"] = 1,
            ["second"] = 2,
            ["third"] = 3
        };

        //Act
        Dictionary<string, int> result = DictionaryIntersection.Intersect(dict1, dict2);

        //Assert
        Assert.That(result, Is.Empty);
    }

    [Test]
    public void Test_Intersect_TwoNonEmptyDictionariesWithCommonKeysAndValues_ReturnsIntersectionDictionary()
    {
        //Arrange
        Dictionary<string, int> dict1 = new Dictionary<string, int>()
        {
            ["first"] = 1,
            ["second"] = 2,
            ["third"] = 3
        };
        Dictionary<string, int> dict2 = new Dictionary<string, int>()
        {
            ["first"] = 1,
            ["second"] = 2,
            ["third"] = 3
        };

        Dictionary<string, int> expected = new Dictionary<string, int>()
        {
            ["first"] = 1,
            ["second"] = 2,
            ["third"] = 3
        };

        //Act
        Dictionary<string, int> result = DictionaryIntersection.Intersect(dict1, dict2);

        //Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_Intersect_TwoNonEmptyDictionariesWithCommonKeysAndDifferentValues_ReturnsEmptyDictionary()
    {
        //Arrange
        Dictionary<string, int> dict1 = new Dictionary<string, int>()
        {
            ["first"] = 4,
            ["second"] = 5,
            ["third"] = 6
        };
        Dictionary<string, int> dict2 = new Dictionary<string, int>()
        {
            ["first"] = 1,
            ["second"] = 2,
            ["third"] = 3
        };

        //Act
        Dictionary<string, int> result = DictionaryIntersection.Intersect(dict1, dict2);

        //Assert
        Assert.That(result, Is.Empty);
    }
}
