namespace MyProject.App.LeetCode75;

/*
    The Problem:
    Find the largest string that, when repeated multiple times, equals both input strings. 
    For example, "ABC" repeated twice gives "ABCABC", so "ABC" divides "ABCABC".

    The Key Insight:
    If a string x divides both str1 and str2, then concatenating them in different orders must produce the same result: str1 + str2 == str2 + str1. 
    This is a mathematical property that eliminates candidates immediately.

    The Solution:

    Check if a solution exists: If str1 + str2 ≠ str2 + str1, return empty string (no common divisor)
    Find the length: The length of the largest dividing string is the GCD (Greatest Common Divisor) of the two input lengths
    Extract the result: Take a substring of that length from either input
    Example:

    str1 = "ABCABC" (length 6), str2 = "ABC" (length 3)
    GCD(6, 3) = 3
    Result = str1[0:3] = "ABC"
    This works because if a string repeats to form both inputs, it must repeat exactly GCD(len1, len2) times in the longer string.
*/

public class GcdOfStrings
{
    public static string Invoke(string str1, string str2)
    {
        // If concatenations don't match, no common divisor exists
        if (str1 + str2 != str2 + str1)
            return string.Empty;
        
        // Find GCD of the two string lengths
        int gcdLength = Gcd(str1.Length, str2.Length);
        
        // Return substring of length gcdLength
        return str1.Substring(0, gcdLength);
    }

    private static int Gcd(int a, int b)
    {
        while (b != 0)
        {
            int temp = b;
            b = a % b;
            a = temp;
        }
        return a;
    }
}