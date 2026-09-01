namespace MyProject.Tests.LeetCode75;

using Xunit;
using MyApp = MyProject.App.LeetCode75.GcdOfStrings;

public class GcdOfStrings
{
    [Fact]
    public void Invoke_Example1_ReturnsAbc()
    {
        var result = MyApp.Invoke("ABCABC", "ABC");
        Assert.Equal("ABC", result);
    }
    
    [Fact]
    public void Invoke_Example2_ReturnsAb()
    {
        var result = MyApp.Invoke("ABABAB", "ABAB");
        Assert.Equal("AB", result);
    }
    
    [Fact]
    public void Invoke_Example3_ReturnsEmpty()
    {
        var result = MyApp.Invoke("LEET", "CODE");
        Assert.Equal(string.Empty, result);
    }
    
    [Fact]
    public void Invoke_Example4_ReturnsEmpty()
    {
        var result = MyApp.Invoke("AAAAAB", "AAA");
        Assert.Equal(string.Empty, result);
    }
}