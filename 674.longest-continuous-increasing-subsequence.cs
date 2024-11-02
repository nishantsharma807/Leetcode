/*
 * @lc app=leetcode id=674 lang=csharp
 *
 * [674] Longest Continuous Increasing Subsequence
 */

// @lc code=start
public class Solution {
    public int FindLengthOfLCIS(int[] nums) {
        int maxSequence = 1;
        int currSequence = 1;

        for(int i = 1; i < nums.Length; i++) {
            if(nums[i] > nums[i - 1]) {
                currSequence++;
            } else {
                maxSequence = Math.Max(maxSequence, currSequence);
                currSequence = 1;
            }
        }

        maxSequence = Math.Max(maxSequence, currSequence);

        return maxSequence;
    }
}
// @lc code=end

