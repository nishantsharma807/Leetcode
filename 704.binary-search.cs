/*
 * @lc app=leetcode id=704 lang=csharp
 *
 * [704] Binary Search
 */

// @lc code=start
public class Solution {
    public int Search(int[] nums, int target) {
        int index = -1, left = 0, right = nums.Length - 1;
        
        while(left <= right) {
            int mid = (left + right) / 2;

            if(nums[mid] == target) return mid;
            else if (target > nums[mid]) left = mid + 1;
            else right = mid - 1;
        }

        return index;
    }
}
// @lc code=end

