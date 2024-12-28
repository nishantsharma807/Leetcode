/*
 * @lc app=leetcode id=53 lang=csharp
 *
 * [53] Maximum Subarray
 */

// @lc code=start
public class Solution {
    public int MaxSubArray(int[] nums) {
        int result = nums[0];
        int sum = 0;

        for(int i = 0; i < nums.Length; i++) {
            sum += nums[i];

            result = Math.Max(sum, result);
            if(sum < 0) sum = 0;
        }

        return result;
    }
}
// @lc code=end

