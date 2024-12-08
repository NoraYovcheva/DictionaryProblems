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
        Dictionary<string, int> expected = new Dictionary<string, int>();

        //Act
        Dictionary<string, int> result = DictionaryIntersection.Intersect(dict1, dict2);

        //Assert
        Assert.That(result, Is.EquivalentTo(expected));
    }

    [Test]
    public void Test_Intersect_OneEmptyDictionaryAndOneNonEmptyDictionary_ReturnsEmptyDictionary()
    {
        //Arrange
        Dictionary<string, int> dict1 = new Dictionary<string, int>();
        Dictionary<string, int> dict2 = new Dictionary<string, int>
        {
            { "Ivan", 5},
            { "Georgi", 8},
            { "Pesho", 4}
        };
        Dictionary<string, int> expected = new Dictionary<string, int>();

        //Act
        Dictionary<string, int> result = DictionaryIntersection.Intersect(dict1, dict2);

        //Assert
        Assert.That(result, Is.EquivalentTo(expected));
    }

    [Test]
    public void Test_Intersect_TwoNonEmptyDictionariesWithNoCommonKeys_ReturnsEmptyDictionary()
    {
        //Arrange
        Dictionary<string, int> dict1 = new Dictionary<string, int> 
        {
            { "Nora", 13},
            { "Mitko", 3},
            { "Sasho", 7}
        };
        Dictionary<string, int> dict2 = new Dictionary<string, int>
        {
            { "Ivan", 5},
            { "Georgi", 8},
            { "Pesho", 4}
        };
        Dictionary<string, int> expected = new Dictionary<string, int>();

        //Act
        Dictionary<string, int> result = DictionaryIntersection.Intersect(dict1, dict2);

        //Assert
        Assert.That(result, Is.EquivalentTo(expected));
    }

    [Test]
    public void Test_Intersect_TwoNonEmptyDictionariesWithCommonKeysAndValues_ReturnsIntersectionDictionary()
    {
        //Arrange
        Dictionary<string, int> dict1 = new Dictionary<string, int>
        {
            { "Nora", 13},
            { "Mitko", 3},
            { "Sasho", 7}
        };
        Dictionary<string, int> dict2 = new Dictionary<string, int>
        {
            { "Nora", 13},
            { "Mitko", 3},
            { "Pesho", 4}
        };
        Dictionary<string, int> expected = new Dictionary<string, int> 
        {
            { "Nora", 13},
            { "Mitko", 3}
        };

        //Act
        Dictionary<string, int> result = DictionaryIntersection.Intersect(dict1, dict2);

        //Assert
        Assert.That(result, Is.EquivalentTo(expected));
    }

    [Test]
    public void Test_Intersect_TwoNonEmptyDictionariesWithCommonKeysAndDifferentValues_ReturnsEmptyDictionary()
    {
        //Arrange
        Dictionary<string, int> dict1 = new Dictionary<string, int>
        {
            { "Nora", 10},
            { "Mitko", 5},
            { "Sasho", 7}
        };
        Dictionary<string, int> dict2 = new Dictionary<string, int>
        {
            { "Nora", 13},
            { "Mitko", 3},
            { "Pesho", 4}
        };
        Dictionary<string, int> expected = new Dictionary<string, int>();

        //Act
        Dictionary<string, int> result = DictionaryIntersection.Intersect(dict1, dict2);

        //Assert
        Assert.That(result, Is.EquivalentTo(expected));
    }
}
