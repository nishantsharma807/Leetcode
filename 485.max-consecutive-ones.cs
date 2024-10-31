/*
 * @lc app=leetcode id=485 lang=csharp
 *
 * [485] Max Consecutive Ones
 */

// @lc code=start
public class Solution {
    public int FindMaxConsecutiveOnes(int[] nums) {
        int result = 0;
        int startIdx = -1;

        for(int i = 0; i < nums.Length; i++) {
            if(nums[i] == 1) {
                if(startIdx == -1) startIdx = i;
                if(i == nums.Length - 1) result = Math.Max(result, nums.Length - startIdx);
            } else if(startIdx > -1 && nums[i] == 0) {                
                result = Math.Max(result, i - startIdx);
                startIdx = -1;
            }
        }

        return result;
    }
}
// @lc code=end

