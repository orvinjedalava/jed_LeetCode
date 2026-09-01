using MyApp = MyProject.App.LeetCode75.MergeStringsAlternately;

namespace MyProject.Tests.LeetCode75;

public class MergeStringsAlternately
{
    [Fact]
    public void MergeStringsAlternately_EqualLengthStrings_ReturnsCorrectMerge()
    {
        // Arrange
        
        string word1 = "abc";
        string word2 = "pqr";
        string expected = "apbqcr";
        
        // Act
        string result = MyApp.Invoke(word1, word2);
        
        // Assert
        Assert.Equal(expected, result);
    }
    
    // [Fact]
    // public void MergeStringsAlternately_FirstStringLonger_AppendsRemainder()
    // {
    //     // Arrange
    //     string word1 = "ab";
    //     string word2 = "pqrs";
    //     string expected = "apbqrs";
        
    //     // Act
    //     string result = LeetCode75.MergeStringsAlternately(word1, word2);
        
    //     // Assert
    //     Assert.Equal(expected, result);
    // }
    
    // [Fact]
    // public void MergeStringsAlternately_SecondStringLonger_AppendsRemainder()
    // {
    //     // Arrange
    //     string word1 = "abcd";
    //     string word2 = "pq";
    //     string expected = "apbqcd";
        
    //     // Act
    //     string result = LeetCode75.MergeStringsAlternately(word1, word2);
        
    //     // Assert
    //     Assert.Equal(expected, result);
    // }
    
    // [Fact]
    // public void MergeStringsAlternately_EmptyFirstString_ReturnsSecondString()
    // {
    //     // Arrange
    //     string word1 = "";
    //     string word2 = "abc";
    //     string expected = "abc";
        
    //     // Act
    //     string result = LeetCode75.MergeStringsAlternately(word1, word2);
        
    //     // Assert
    //     Assert.Equal(expected, result);
    // }
    
    // [Fact]
    // public void MergeStringsAlternately_EmptySecondString_ReturnsFirstString()
    // {
    //     // Arrange
    //     string word1 = "abc";
    //     string word2 = "";
    //     string expected = "abc";
        
    //     // Act
    //     string result = LeetCode75.MergeStringsAlternately(word1, word2);
        
    //     // Assert
    //     Assert.Equal(expected, result);
    // }

}
