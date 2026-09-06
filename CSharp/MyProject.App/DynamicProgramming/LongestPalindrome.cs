namespace MyProject.App.DynamicProgramming;
/*
Given a string s, return the longest palindromic substring in s.

Example 1:

Input: s = "babad"
Output: "bab"
Explanation: "aba" is also a valid answer.
Example 2:

Input: s = "cbbd"
Output: "bb"
 
Constraints:

1 <= s.length <= 1000
s consist of only digits and English letters.
*/

public class LongestPalindrome
{
    /*
    This uses the standard "expand around center" approach, 
    checking both odd-length (single-character center) 
    and even-length (two-character center) palindromes.
    */
    public static string Invoke(string s)
    {
        if (string.IsNullOrEmpty(s)) return s;

        int start = 0, maxLength = 1;

        for (int i = 0; i < s.Length; i++)
        {
            ExpandAroundCenter(s, i, i, ref start, ref maxLength);     // odd-length palindromes
            ExpandAroundCenter(s, i, i + 1, ref start, ref maxLength); // even-length palindromes
        }

        return s.Substring(start, maxLength);
    }

    private static void ExpandAroundCenter(string s, int left, int right, ref int start, ref int maxLength)
    {
        while (left >= 0 && right < s.Length && s[left] == s[right])
        {
            left--;
            right++;
        }

        int length = right - left - 1;
        if (length > maxLength)
        {
            start = left + 1;
            maxLength = length;
        }
    }
}