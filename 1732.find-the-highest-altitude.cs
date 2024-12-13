/*
 * @lc app=leetcode id=1732 lang=csharp
 *
 * [1732] Find the Highest Altitude
 */

// @lc code=start
public class Solution {
    public int LargestAltitude(int[] gain) {
        int result = 0, current = 0;

        for(int i = 0; i < gain.Length; i++) {
            current += gain[i];
            result = Math.Max(result, current);
        }

        return result;
    }
}
// @lc code=end

