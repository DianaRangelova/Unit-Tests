using NUnit.Framework;

namespace TestApp.Tests;

[TestFixture]
public class StringModifierTests
{
    [Test]
    public void Test_Modify_EmptyString_ReturnsEmptyString()
    {
        // Arrange
        string input = string.Empty;

        // Act
        string output = StringModifier.Modify(input);

        // Assert
        Assert.That(output, Is.EqualTo(string.Empty));
    }

    [Test]
    public void Test_Modify_SingleWordWithEvenLength_ReturnsUppperCaseWord()
    {
        // Arrange
        string input = "didi";
        string expected = "DIDI";

        // Act
        string output = StringModifier.Modify(input);

        // Assert
        Assert.That(output, Is.EqualTo(expected));
    }

    [Test]
    public void Test_Modify_SingleWordWithOddLength_ReturnsToLowerCaseWord()
    {
        // Arrange
        string input = "DiDka";
        string expected = "didka";

        // Act
        string output = StringModifier.Modify(input);

        // Assert
        Assert.That(output, Is.EqualTo(expected));
    }

    [Test]
    public void Test_Modify_MultipleWords_ReturnsModifiedString()
    {
        // Arrange
        string input = "SoftUni the best";
        string expected = "softuni the BEST";

        // Act
        string output = StringModifier.Modify(input);

        // Assert
        Assert.That(output, Is.EqualTo(expected));
    }
}

