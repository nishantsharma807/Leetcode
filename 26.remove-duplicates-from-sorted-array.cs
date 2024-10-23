/*
 * @lc app=leetcode id=26 lang=csharp
 *
 * [26] Remove Duplicates from Sorted Array
 */

// @lc code=start
public class Solution {
    public int RemoveDuplicates(int[] nums) {
        var lastIdx = 1;

        for (int i = 0; i < nums.Length - 1; i++) {
            if(nums[i] != nums[i+1]) 
            {
                nums[lastIdx] = nums[i+1];
                lastIdx++;
            }
        }

        return lastIdx;
        
    }
}
// @lc code=end

