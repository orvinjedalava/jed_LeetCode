using System.Text;

namespace MyProject.App.LeetCode75;

public class MergeStringsAlternately
{
    public static string Invoke(string word1, string word2)
    {
        var result = new StringBuilder();
        int i = 0;
        
        while(i < word1.Length || i < word2.Length)
        {
            if (i < word1.Length)
                result.Append(word1[i]);
            if ( i < word2.Length)
                result.Append(word2[i]); 
            i++;
        }

        return result.ToString();
    }
}