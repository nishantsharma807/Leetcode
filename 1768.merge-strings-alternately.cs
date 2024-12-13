/*
 * @lc app=leetcode id=1768 lang=csharp
 *
 * [1768] Merge Strings Alternately
 */

// @lc code=start
public class Solution {
    public string MergeAlternately(string word1, string word2) {
        StringBuilder result = new StringBuilder();
        
        for(int i = 0; i < Math.Max(word1.Length, word2.Length); i++) {
            if(i < word1.Length) result.Append(word1[i]);
            if(i < word2.Length) result.Append(word2[i]);
        }

        return result.ToString();
    }
}
// @lc code=end

