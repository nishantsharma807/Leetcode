/*
 * @lc app=leetcode id=540 lang=csharp
 *
 * [540] Single Element in a Sorted Array
 */

// @lc code=start
public class Solution {
    public int SingleNonDuplicate(int[] nums) {
        if(nums.Length == 1) return nums[0];
        if(nums[0] != nums[1]) return nums[0];
        if(nums[nums.Length - 1] != nums[nums.Length - 2]) return nums[nums.Length - 1];

        int low = 1, high = nums.Length - 2;

        while(low <= high) {
            int mid = (low + high) / 2;

            if(nums[mid] != nums[mid - 1] && nums[mid] != nums[mid + 1]) return nums[mid];

            if((mid % 2 == 1 && nums[mid] == nums[mid - 1]) || 
                (mid % 2 == 0 && nums[mid] == nums[mid + 1])) 
            {                
                low = mid + 1;
            }
            else {
                high = mid - 1;
            }
        }

        return -1;
    }
}
// @lc code=end

