/*
 * @lc app=leetcode id=283 lang=csharp
 *
 * [283] Move Zeroes
 */

// @lc code=start
public class Solution {
    public void MoveZeroes(int[] nums) {
        int j = 0;

        for(int i = 0; i < nums.Length; i++) 
        {
            if(nums[i] != 0) 
            {
                var temp = nums[i];
                nums[i] = nums[j];
                nums[j] = temp;
                j++;
            }
        }
    }
}
// @lc code=end

