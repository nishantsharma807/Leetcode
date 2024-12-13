/*
 * @lc app=leetcode id=724 lang=csharp
 *
 * [724] Find Pivot Index
 */

// @lc code=start
public class Solution {
    public int PivotIndex(int[] nums) {
        int leftSum = 0, totalSum = 0;

        foreach(int n in nums) {
            totalSum += n;
        }

        for(int i = 0; i < nums.Length; i++) {
            if(leftSum == (totalSum - nums[i] - leftSum)) return i;
            leftSum += nums[i];
        }

        return -1;
    }
}
// @lc code=end

