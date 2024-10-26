/*
 * @lc app=leetcode id=268 lang=csharp
 *
 * [268] Missing Number
 */

// @lc code=start
public class Solution {
    public int MissingNumber(int[] nums) {
        int remainingSum = (nums.Length * (nums.Length + 1))/2;

        foreach(int num in nums) {
            remainingSum -= num;
        }

        return remainingSum;
    }
}
// @lc code=end

