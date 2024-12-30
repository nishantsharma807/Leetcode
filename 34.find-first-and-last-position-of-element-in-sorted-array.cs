/*
 * @lc app=leetcode id=34 lang=csharp
 *
 * [34] Find First and Last Position of Element in Sorted Array
 */

// @lc code=start
public class Solution {
    public int[] SearchRange(int[] nums, int target) {
        int index = -1, left = 0, right = nums.Length - 1;
        
        while(left <= right) {
            int mid = (left + right) / 2;

            if(nums[mid] == target) {
                int index1 = mid, index2 = mid;

                while(index1 > 0 && nums[index1 - 1] == target) index1--;
                while(index2 < nums.Length - 1 && nums[index2 + 1] == target) index2++;

                return new int[] { index1, index2 };
            }
            else if (target > nums[mid]) left = mid + 1;
            else right = mid - 1;
        }

        return new int[] { -1, -1 };
    }
}
// @lc code=end

