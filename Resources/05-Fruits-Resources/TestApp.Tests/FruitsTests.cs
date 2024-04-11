using System.Collections.Generic;

using NUnit.Framework;

namespace TestApp.Tests;

[TestFixture]
public class FruitsTests
{
    [Test]
    public void Test_GetFruitQuantity_FruitExists_ReturnsQuantity()
    {
        // Arrange
        Dictionary<string, int> fruitsDictionary = new()
        {
            { "bannana", 5 },
            { "strawberry", 10 },
            { "raspberry", 15 }
        };

        string expectedFruit = "strawberry";
        int expected = 10;

        // Act 
        int result = Fruits.GetFruitQuantity(fruitsDictionary, expectedFruit);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_GetFruitQuantity_FruitDoesNotExist_ReturnsZero()
    {
        // Arrange
        Dictionary<string, int> fruitsDictionary = new()
        {
            { "bannana", 5 },
            { "strawberry", 10 },
            { "raspberry", 15 }
        };

        string expectedFruit = "orange";
        int expected = 0;

        // Act 
        int result = Fruits.GetFruitQuantity(fruitsDictionary, expectedFruit);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_GetFruitQuantity_EmptyDictionary_ReturnsZero()
    {
        // Arrange
        Dictionary<string, int> fruitsDictionary = new();

        string expectedFruit = "strawberry";
        int expected = 0;

        // Act 
        int result = Fruits.GetFruitQuantity(fruitsDictionary, expectedFruit);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_GetFruitQuantity_NullDictionary_ReturnsZero()
    {
        // Arrange
        Dictionary<string, int> fruitsDictionary = null;

        string expectedFruit = "strawberry";
        int expected = 0;

        // Act 
        int result = Fruits.GetFruitQuantity(fruitsDictionary, expectedFruit);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_GetFruitQuantity_NullFruitName_ReturnsZero()
    {
        // Arrange
        Dictionary<string, int> fruitsDictionary = new();

        string expectedFruit = null;
        int expected = 0;

        // Act 
        int result = Fruits.GetFruitQuantity(fruitsDictionary, expectedFruit);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }
}
