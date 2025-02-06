/*
 * @lc app=leetcode id=930 lang=csharp
 *
 * [930] Binary Subarrays With Sum
 */

// @lc code=start
public class Solution {    
    public int NumSubarraysWithSum(int[] nums, int goal) {
        return NumSubarrays(nums, goal) - NumSubarrays(nums, goal - 1);
    }

    private int NumSubarrays(int[] nums, int goal) {
        if(goal < 0) return 0;
        int result = 0, left = 0, right = 0, sum = 0; 

        while(right < nums.Length) {
            sum += nums[right];

            while(sum > goal) {
                sum -= nums[left];
                left++;
            }

            result = result + (right - left + 1);
            right++;
        }

        return result;
    }
}
// @lc code=end

