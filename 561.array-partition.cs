/*
 * @lc app=leetcode id=561 lang=csharp
 *
 * [561] Array Partition
 */

// @lc code=start
public class Solution {
    public int ArrayPairSum(int[] nums) {
        var maxSum = 0;
        Array.Sort(nums);

        for(int i = 0; i < nums.Length; i+=2) {
            maxSum += Math.Min(nums[i], nums[i+1]);
        }

        return maxSum;
    }
}
// @lc code=end

