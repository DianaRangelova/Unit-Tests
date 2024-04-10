using NUnit.Framework;

namespace TestApp.Tests;

[TestFixture]
public class StringRotatorTests
{
    [Test]
    public void Test_RotateRight_EmptyString_ReturnsEmptyString()
    {
        // Arrange
        string input = string.Empty;
        int position = 3;

        // Act
        string result = StringRotator.RotateRight(input, position);

        // Assert
        Assert.That(result, Is.Empty);
    }

    [Test]
    public void Test_RotateRight_RotateByZeroPositions_ReturnsOriginalString()
    {
        // Arrange
        string input = "rotatebyzero";
        int position = 0;
        string expected = input;

        // Act
        string result = StringRotator.RotateRight(input, position);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_RotateRight_RotateByPositivePositions_ReturnsRotatedString()
    {
        // Arrange
        string input = "rotatebyzero";
        int position = 2;
        string expected = "rorotatebyze";

        // Act
        string result = StringRotator.RotateRight(input, position);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_RotateRight_RotateByNegativePositions_ReturnsRotatedString()
    {
        // Arrange
        string input = "rotatebyzero";
        int position = -1;
        string expected = "orotatebyzer";

        // Act
        string result = StringRotator.RotateRight(input, position);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_RotateRight_RotateByMorePositionsThanStringLength_ReturnsRotatedString()
    {
        // Arrange
        string input = "rotate";
        int position = 10;
        string expected = "tatero";

        // Act
        string result = StringRotator.RotateRight(input, position);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }
}
