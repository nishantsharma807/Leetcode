/*
 * @lc app=leetcode id=771 lang=csharp
 *
 * [771] Jewels and Stones
 */

// @lc code=start
public class Solution {
    public int NumJewelsInStones(string jewels, string stones) {
        var setJewels = new HashSet<char>(jewels.ToCharArray());
        int result = 0;

        foreach(char c in stones) {
            if(setJewels.Contains(c)) result++;
        }

        return result;
    }
}
// @lc code=end

