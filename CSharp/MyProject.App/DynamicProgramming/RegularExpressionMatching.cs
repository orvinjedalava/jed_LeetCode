namespace MyProject.App.DynamicProgramming;

/*
Given an input string s and a pattern p, implement regular expression matching with support for '.' and '*' where:

'.' Matches any single character.​​​​
'*' Matches zero or more of the preceding element.
Return a boolean indicating whether the matching covers the entire input string (not partial).

 

Example 1:

Input: s = "aa", p = "a"
Output: false
Explanation: "a" does not match the entire string "aa".
Example 2:

Input: s = "aa", p = "a*"
Output: true
Explanation: '*' means zero or more of the preceding element, 'a'. Therefore, by repeating 'a' once, it becomes "aa".
Example 3:

Input: s = "ab", p = ".*"
Output: true
Explanation: ".*" means "zero or more (*) of any character (.)".
 

Constraints:

1 <= s.length <= 20
1 <= p.length <= 20
s contains only lowercase English letters.
p contains only lowercase English letters, '.', and '*'.
It is guaranteed for each appearance of the character '*', there will be a previous valid character to match.
*/
public class RegularExpressionMatching
{
    /*
    Core idea: dp[i, j] answers "does s[i..] match p[j..]?" (the remaining suffixes of both strings, starting at index i in s and j in p). 
    We build this table from the end of both strings backward to the beginning, 
    since matching a * requires knowing about future/shorter suffixes first.
    */
    /// <summary>
    /// 
    /// </summary>
    /// <param name="s">Input String</param>
    /// <param name="p">Regex Pattern</param>
    /// <returns></returns>
    public static bool Invoke(string s, string p)
    {
        int m = s.Length, n = p.Length;
        // dp[i, j] = true if s[i..] matches p[j..]
        bool[,] dp = new bool[m + 1, n + 1];
        dp[m, n] = true; // empty Input String matches empty Regex Pattern

        for (int i = m; i >= 0; i--)
        {
            for (int j = n - 1; j >= 0; j--)
            {
                bool firstMatch = i < m && (p[j] == s[i] || p[j] == '.');

                if (j + 1 < n && p[j + 1] == '*')
                {
                    // zero occurrences (skip "x*") OR one+ occurrences (consume s[i], stay on same pattern position)
                    dp[i, j] = dp[i, j + 2] || (firstMatch && dp[i + 1, j]);
                }
                else
                {
                    // no '*': consume one char from both s and p
                    dp[i, j] = firstMatch && dp[i + 1, j + 1];
                }
            }
        }

        return dp[0, 0];
    }
}