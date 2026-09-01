namespace MyProject.App.DynamicProgramming;

/// <summary>
/// This is a classic dynamic programming problem. The key insight is that to reach step n, you can either:
/// 
/// Come from step n-1 and take 1 step, OR
/// Come from step n-2 and take 2 steps
/// Therefore: ways(n) = ways(n-1) + ways(n-2) — this is the Fibonacci sequence!
/// 
/// Confusion explanation by Claude Sonnet 5
/// I see the confusion — you're conflating "2 choices" (the number of options) with "+2" (adding the literal number 2). These are different things. Let me clarify.
/// The "2" is Just How Many Branches Exist — Not What Gets Added
/// There are exactly 2 choices for your last move (1-step or 2-step), but the number of ways from each choice is variable, not fixed at 2.
/// 
/// ways(n) = ways(n-1) + ways(n-2)
///          ^^^^^^^^^   ^^^^^^^^^
///          branch #1   branch #2
///          (1-step)    (2-step)
/// 
/// We're adding the counts of paths from each branch -- not adding the number "2" itself
/// 
/// ways(5) = ways(4) + ways(3)
///         = 5        + 3
///         = 8
/// 
/// Branch 1 (last move = 1 step): contributes 5 ways (however many ways exist to reach step 4)
/// Branch 2 (last move = 2 steps): contributes 3 ways (however many ways exist to reach step 3)
/// We add these two counts together: 5 + 3 = 8
///
/// 
/// </summary>
public class ClimbingStairs
{
    public static int Invoke(int n)
    {
        // Base cases
        if (n == 1) return 1;
        if (n == 2) return 2;
        
        // DP approach: each step can be reached from previous two steps
        int prev2 = 1;  // ways to reach step 1
        int prev1 = 2;  // ways to reach step 2
        
        for (int i = 3; i <= n; i++)
        {
            int current = prev1 + prev2;
            prev2 = prev1;
            prev1 = current;
        }
        
        return prev1;
    }
}