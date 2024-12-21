/*
 * @lc app=leetcode id=977 lang=csharp
 *
 * [977] Squares of a Sorted Array
 */

// @lc code=start
public class Solution {
    public int[] SortedSquares(int[] nums) {
        var result = new int[nums.Length];
        int left = 0, right = nums.Length - 1;

        for(int i = right; i >= 0; i--) {
            int num;

            if(Math.Abs(nums[right]) > Math.Abs(nums[left])) {
                num = nums[right];
                right--;
            }
            else {
                num = nums[left];
                left++;
            }

            result[i] = num * num;
        }

        return result;
    }
}
// @lc code=end

