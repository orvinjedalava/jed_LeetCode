using MyApp = MyProject.App.DynamicProgramming.LongestPalindrome;

namespace MyProject.Tests.DynamicProgramming;

public class LongestPalindromeTests
{
    [Fact]
    public void Invoke_Babad_ReturnsBabOrAba()
    {
        // Arrange & Act
        string result = MyApp.Invoke("babad");

        // Assert
        Assert.True(result == "bab" || result == "aba");
    }

    [Fact]
    public void Invoke_Cbbd_ReturnsBb()
    {
        // Arrange & Act
        string result = MyApp.Invoke("cbbd");

        // Assert
        Assert.Equal("bb", result);
    }

    [Fact]
    public void Invoke_SingleCharacter_ReturnsSameCharacter()
    {
        // Arrange & Act
        string result = MyApp.Invoke("a");

        // Assert
        Assert.Equal("a", result);
    }

    [Fact]
    public void Invoke_AllSameCharacters_ReturnsWholeString()
    {
        // Arrange & Act
        string result = MyApp.Invoke("aaaa");

        // Assert
        Assert.Equal("aaaa", result);
    }

    [Fact]
    public void Invoke_NoPalindromeLongerThanOne_ReturnsSingleCharacter()
    {
        // Arrange & Act
        string result = MyApp.Invoke("ac");

        // Assert
        Assert.Equal(1, result.Length);
    }

    [Fact]
    public void Invoke_EntireStringIsPalindrome_ReturnsWholeString()
    {
        // Arrange & Act
        string result = MyApp.Invoke("racecar");

        // Assert
        Assert.Equal("racecar", result);
    }
}