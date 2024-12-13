/*
 * @lc app=leetcode id=238 lang=csharp
 *
 * [238] Product of Array Except Self
 */

// @lc code=start
public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        int[] result = new int[nums.Length];
        int left = 1, right = 1;
        result[0] = 1;
        
        for(int i = 1; i < nums.Length; i++) {
            left *=  nums[i - 1];
            result[i] = left;
        }

        for(int i = nums.Length-2; i >= 0; i--) {
            right *= nums[i + 1];
            result[i] *= right;
        }
        
        return result;
    }
}
// @lc code=end

