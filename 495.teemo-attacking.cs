/*
 * @lc app=leetcode id=495 lang=csharp
 *
 * [495] Teemo Attacking
 */

// @lc code=start
public class Solution {
    public int FindPoisonedDuration(int[] timeSeries, int duration) {
        int result = 0;

        for(int i = 0; i < timeSeries.Length - 1; i++) {
            result += Math.Min(timeSeries[i + 1] - timeSeries[i], duration);
        }
        
        return result + duration;
    }
}
// @lc code=end

