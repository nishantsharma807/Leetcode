/*
 * @lc app=leetcode id=643 lang=csharp
 *
 * [643] Maximum Average Subarray I
 */

// @lc code=start
public class Solution {
    public double FindMaxAverage(int[] nums, int k) {
        double maxSum = 0;
        double currSum = 0;

        for(int i = 0; i < k; i++) {
            currSum += nums[i];
        }

        maxSum = currSum;

        for(int i = k; i < nums.Length; i++) {
            currSum += nums[i] - nums[i - k];
            maxSum = Math.Max(maxSum, currSum);
        }

        return maxSum / k;
    }
}
// @lc code=end

