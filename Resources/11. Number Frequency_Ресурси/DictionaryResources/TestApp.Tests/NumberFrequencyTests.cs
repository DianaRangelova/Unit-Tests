using System.Collections.Generic;

using NUnit.Framework;

namespace TestApp.Tests;

[TestFixture]
public class NumberFrequencyTests
{
    [Test]
    public void Test_CountDigits_ZeroNumber_ReturnsEmptyDictionary()
    {
        // Arrange
        int number = 0;

        // Act
        Dictionary<int, int> result = NumberFrequency.CountDigits(number);

        // Assert
        Assert.That(result, Is.Empty);
    }

    [Test]
    public void Test_CountDigits_SingleDigitNumber_ReturnsDictionaryWithSingleEntry()
    {
        // Arrange
        int number = 5;

        Dictionary<int, int> expected = new()
        {
            { 5, 1 }
        };

        // Act
        Dictionary<int, int> result = NumberFrequency.CountDigits(number);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_CountDigits_MultipleDigitNumber_ReturnsDictionaryWithDigitFrequencies()
    {
        // Arrange
        int number = 1234522255;

        Dictionary<int, int> expected = new()
        {
            { 1, 1 },
            { 2, 4 },
            { 3, 1 },
            { 4, 1 },
            { 5, 3 }
        };

        // Act
        Dictionary<int, int> result = NumberFrequency.CountDigits(number);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_CountDigits_NegativeNumber_ReturnsDictionaryWithDigitFrequencies()
    {
        // Arrange
        int number = -112223234;

        Dictionary<int, int> expected = new()
        {
            { 1, 2 },
            { 2, 4 },
            { 3, 2 },
            { 4, 1 },
        };

        // Act
        Dictionary<int, int> result = NumberFrequency.CountDigits(number);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }
}
