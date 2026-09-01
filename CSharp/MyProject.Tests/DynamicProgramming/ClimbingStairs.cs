using MyApp = MyProject.App.DynamicProgramming.ClimbingStairs;

namespace MyProject.Tests.DynamicProgramming;

public class ClimbingStairsTests
{
    [Fact]
    public void Invoke_SingleStep_ReturnsOne()
    {
        // Arrange & Act
        int result = MyApp.Invoke(1);
        
        // Assert
        Assert.Equal(1, result);
    }
    
    [Fact]
    public void Invoke_TwoSteps_ReturnsTwo()
    {
        // Arrange & Act
        int result = MyApp.Invoke(2);
        
        // Assert
        Assert.Equal(2, result);
    }
    
    [Fact]
    public void Invoke_ThreeSteps_ReturnsThree()
    {
        // Arrange & Act
        int result = MyApp.Invoke(3);
        
        // Assert
        Assert.Equal(3, result);
    }
    
    [Fact]
    public void Invoke_FourSteps_ReturnsFive()
    {
        // Arrange & Act
        int result = MyApp.Invoke(4);
        
        // Assert
        Assert.Equal(5, result);
    }
    
    [Fact]
    public void Invoke_FiveSteps_ReturnsEight()
    {
        // Arrange & Act
        int result = MyApp.Invoke(5);
        
        // Assert
        Assert.Equal(8, result);
    }
    
    [Fact]
    public void Invoke_LargeN_CalculatesCorrectly()
    {
        // Arrange & Act
        int result = MyApp.Invoke(10);
        
        // Assert
        Assert.Equal(89, result);
    }
}