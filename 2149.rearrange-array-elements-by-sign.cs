/*
 * @lc app=leetcode id=2149 lang=csharp
 *
 * [2149] Rearrange Array Elements by Sign
 */

// @lc code=start
public class Solution {
    public int[] RearrangeArray(int[] nums) {
        int[] result = new int[nums.Length];
        int evenIndex = 0, oddIndex = 1;

        for(int i = 0; i < nums.Length; i++) {
            if(nums[i] >= 0) {
                result[evenIndex] = nums[i];
                evenIndex += 2;
            }
            else {
                result[oddIndex] = nums[i];
                oddIndex += 2;
            }
        }

        return result;
    }
}
// @lc code=end

