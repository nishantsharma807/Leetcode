/*
 * @lc app=leetcode id=1752 lang=csharp
 *
 * [1752] Check if Array Is Sorted and Rotated
 */

// @lc code=start
public class Solution {
    public bool Check(int[] nums) {
        int count = 0;

        for(int i = 0; i < nums.Length; i++) {
            int nextIdx = (i + 1) % nums.Length; 
            
            if(nums[i] > nums[nextIdx]) count++;
            if(count > 1) return false;
        }

        return true;
    }
}
// @lc code=end

