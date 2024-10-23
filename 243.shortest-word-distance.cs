/*
 * @lc app=leetcode id=243 lang=csharp
 *
 * [243] Shortest Word Distance
 */

// @lc code=start
public class Solution {
    public int ShortestDistance(string[] wordsDict, string word1, string word2) {
        int shortestDistance = wordsDict.Length;
        int word1Idx = -1;
        int word2Idx = -1;

        for(int i = 0; i < wordsDict.Length; i++) {
            if(wordsDict[i] == word1) word1Idx = i;
            else if(wordsDict[i] == word2) word2Idx = i;

            if(word1Idx >= 0 && word2Idx >= 0) {
                shortestDistance = Math.Min(shortestDistance, Math.Abs(word1Idx - word2Idx));
            }
        }

        return shortestDistance;
    }
}
// @lc code=end

