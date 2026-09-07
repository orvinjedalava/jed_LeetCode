using MyApp = MyProject.App.DynamicProgramming.RegularExpressionMatching;

namespace MyProject.Tests.DynamicProgramming;

public class RegularExpressionMatchingTests
{
    [Fact]
    public void Invoke_ExactMatch_ReturnsTrue()
    {
        // Arrange & Act
        bool result = MyApp.Invoke("aa", "a");

        // Assert
        Assert.False(result);
    }

    [Fact]
    public void Invoke_StarRepeatsPrecedingChar_ReturnsTrue()
    {
        // Arrange & Act
        bool result = MyApp.Invoke("aa", "a*");

        // Assert
        Assert.True(result);
    }

    [Fact]
    public void Invoke_DotStarMatchesAnything_ReturnsTrue()
    {
        // Arrange & Act
        bool result = MyApp.Invoke("ab", ".*");

        // Assert
        Assert.True(result);
    }

    [Fact]
    public void Invoke_MismatchedCharacters_ReturnsFalse()
    {
        // Arrange & Act
        bool result = MyApp.Invoke("mississippi", "mis*is*p*.");

        // Assert
        Assert.False(result);
    }

    [Fact]
    public void Invoke_StarMatchesZeroOccurrences_ReturnsTrue()
    {
        // Arrange & Act
        bool result = MyApp.Invoke("ab", ".*c");

        // Assert
        Assert.False(result);
    }

    [Fact]
    public void Invoke_ComplexPattern_ReturnsTrue()
    {
        // Arrange & Act
        bool result = MyApp.Invoke("aab", "c*a*b");

        // Assert
        Assert.True(result);
    }

    [Fact]
    public void Invoke_EmptyPatternNonEmptyString_ReturnsFalse()
    {
        // Arrange & Act
        bool result = MyApp.Invoke("a", "");

        // Assert
        Assert.False(result);
    }
}