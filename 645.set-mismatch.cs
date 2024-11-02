/*
 * @lc app=leetcode id=645 lang=csharp
 *
 * [645] Set Mismatch
 */

// @lc code=start
public class Solution {
    public int[] FindErrorNums(int[] nums) {
        int[] result = new int[2];
        var setNums = new HashSet<int>();
        var remainingSum = (nums.Length * (nums.Length + 1)) / 2;

        for(int i = 0; i < nums.Length; i++) {
            if(setNums.Contains(nums[i])) {
                result[0] = nums[i];
            }
            else {
                setNums.Add(nums[i]);
                remainingSum -= nums[i];
            }
        }

        result[1] = remainingSum;

        return result;
    }
}
// @lc code=end

