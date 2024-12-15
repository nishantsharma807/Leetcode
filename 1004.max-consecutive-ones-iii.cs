/*
 * @lc app=leetcode id=1004 lang=csharp
 *
 * [1004] Max Consecutive Ones III
 */

// @lc code=start
public class Solution {
    public int LongestOnes(int[] nums, int k) {
        int result = 0, left = 0, right = 0, zeros = 0;

        while(right < nums.Length) {
            if(nums[right] == 0) zeros++;

            if(zeros > k) {
                if(nums[left] == 0) zeros--;
                left++;
            }
            
            if(zeros <= k) {
                result = Math.Max(result, right - left + 1);
            }

            right++;
        }

        return result;
    }
}
// @lc code=end

