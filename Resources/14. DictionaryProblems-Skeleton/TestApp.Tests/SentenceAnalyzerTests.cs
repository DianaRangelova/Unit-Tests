using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using NUnit.Framework;

namespace TestApp.Tests;

[TestFixture]
public class SentenceAnalyzerTests
{
    [Test]
    public void Test_Analyze_EmptyString_ReturnsEmptyDictionary()
    {
        // Arrange
        string input = string.Empty;

        // Act
        Dictionary<string, int> result = SentenceAnalyzer.Analyze(input);

        // Assert
        Assert.That(result, Is.Empty);
    }

    [Test]
    public void Test_Analyze_SingleLetter_ReturnsDictionaryWithSingleLetterEntry()
    {
        // Arrange
        Dictionary<string, int> symbolTypes = new();
        string input = "D";
        Dictionary<string, int> expected = new()
        {
            { "letters", 1 }
        };

        // Act
        var result = SentenceAnalyzer.Analyze(input);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_Analyze_SingleDigit_ReturnsDictionaryWithSingleDigitEntry()
    {
        /// Arrange
        Dictionary<string, int> symbolTypes = new();
        string input = "1";
        Dictionary<string, int> expected = new()
        {
            { "digits", 1 }
        };

        // Act
        var result = SentenceAnalyzer.Analyze(input);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_Analyze_WholeSentence_ReturnsDictionaryWithAllSymbolTypesCount()
    {
        // Arrange
        Dictionary<string, int> symbolTypes = new();
        string input = "Unit testing is the 1st step!!!";
        Dictionary<string, int> expected = new()
        {
            { "letters", 22 },
            { "digits", 1 },
            { "special characters", 3 }
        };

        // Act
        var result = SentenceAnalyzer.Analyze(input);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }
}

