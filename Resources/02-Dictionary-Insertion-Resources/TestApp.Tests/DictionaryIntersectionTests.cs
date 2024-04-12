using System.Collections.Generic;

using NUnit.Framework;

namespace TestApp.Tests;

[TestFixture]
public class DictionaryIntersectionTests
{
    [Test]
    public void Test_Intersect_TwoEmptyDictionaries_ReturnsEmptyDictionary()
    {
        // Arrange
        Dictionary<string, int> dict1 = new();
        Dictionary<string, int> dict2 = new();

        // Act
        Dictionary<string, int> result = DictionaryIntersection.Intersect(dict1, dict2);

        // Assert
        Assert.That(result, Is.Empty);
    }

    [Test]
    public void Test_Intersect_OneEmptyDictionaryAndOneNonEmptyDictionary_ReturnsEmptyDictionary()
    {
        // Arrange
        Dictionary<string, int> dict1 = new();
        Dictionary<string, int> dict2 = new()
        {
            {"monkey", 2},
            {"dog", 5},
            {"cat", 3}
        };

        // Act
        Dictionary<string, int> result = DictionaryIntersection.Intersect(dict1, dict2);

        // Assert
        Assert.That(result, Is.Empty);
    }

    [Test]
    public void Test_Intersect_TwoNonEmptyDictionariesWithNoCommonKeys_ReturnsEmptyDictionary()
    {
        // Arrange
        Dictionary<string, int> dict1 = new()
        {
            {"monkey", 2},
            {"dog", 5},
            {"cat", 3}
        };
        Dictionary<string, int> dict2 = new()
        {
            { "snake", 2},
            { "hippopotamus", 5},
            { "frog", 3}
        };

        // Act
        Dictionary<string, int> result = DictionaryIntersection.Intersect(dict1, dict2);

        // Assert
        Assert.That(result, Is.Empty);
    }

    [Test]
    public void Test_Intersect_TwoNonEmptyDictionariesWithCommonKeysAndValues_ReturnsIntersectionDictionary()
    {
        // Arrange
        Dictionary<string, int> dict1 = new()
        {
            {"monkey", 2},
            {"dog", 5},
            {"cat", 3},
            {"snake", 2},
            {"hippopotamus", 5}
        };
        Dictionary<string, int> dict2 = new()
        {
            { "snake", 2},
            { "hippopotamus", 5},
            { "frog", 3}
        };

        Dictionary<string, int> expected = new()
        {
            {"snake", 2},
            {"hippopotamus", 5}
        };

        // Act
        Dictionary<string, int> result = DictionaryIntersection.Intersect(dict1, dict2);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_Intersect_TwoNonEmptyDictionariesWithCommonKeysAndDifferentValues_ReturnsEmptyDictionary()
    {
        // Arrange
        Dictionary<string, int> dict1 = new()
        {
            {"monkey", 2},
            {"dog", 5},
            {"cat", 3},
            {"snake", 8},
            {"hippopotamus", 6}
        };
        Dictionary<string, int> dict2 = new()
        {
            { "snake", 2},
            { "hippopotamus", 5},
            { "gazelle", 1},
        };

        // Act
        Dictionary<string, int> result = DictionaryIntersection.Intersect(dict1, dict2);

        // Assert
        Assert.That(result, Is.Empty);
    }
}
