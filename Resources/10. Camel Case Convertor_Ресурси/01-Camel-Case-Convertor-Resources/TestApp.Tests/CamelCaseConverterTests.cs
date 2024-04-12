using NUnit.Framework;

namespace TestApp.Tests;

[TestFixture]
public class CamelCaseConverterTests
{
    [Test]
    public void Test_ConvertToCamelCase_EmptyString_ReturnsEmptyString()
    {
        // Arrange
        string input = string.Empty;

        // Act
        string output = CamelCaseConverter.ConvertToCamelCase(input);

        // Assert
        Assert.That(output, Is.EqualTo(string.Empty));
    }

    [Test]
    public void Test_ConvertToCamelCase_SingleWord_ReturnsLowercaseWord()
    {
        // Arrange
        string input = "CamelCase";
        string expected = "camelcase";

        // Act
        string output = CamelCaseConverter.ConvertToCamelCase(input);

        // Assert
        Assert.That(output, Is.EqualTo(expected));
    }

    [Test]
    public void Test_ConvertToCamelCase_MultipleWords_ReturnsCamelCase()
    {
        // Arrange
        string input = "one two three";
        string expected = "oneTwoThree";

        // Act
        string output = CamelCaseConverter.ConvertToCamelCase(input);

        // Assert
        Assert.That(output, Is.EqualTo(expected));
    }

    [Test]
    public void Test_ConvertToCamelCase_MultipleWordsWithMixedCase_ReturnsCamelCase()
    {
        // Arrange
        string input = "ONe TwO tHREE";
        string expected = "oneTwoThree";

        // Act
        string output = CamelCaseConverter.ConvertToCamelCase(input);

        // Assert
        Assert.That(output, Is.EqualTo(expected));
    }
}
