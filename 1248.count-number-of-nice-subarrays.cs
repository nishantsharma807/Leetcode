/*
 * @lc app=leetcode id=1248 lang=csharp
 *
 * [1248] Count Number of Nice Subarrays
 */

// @lc code=start
public class Solution {
    public int NumberOfSubarrays(int[] nums, int k) {
        return NumofArrays(nums, k) - NumofArrays(nums, k - 1);
    }

    private int NumofArrays(int[] nums, int k) {
        if(k < 0) return 0;
        int left = 0, right = 0, sum = 0, result = 0;

        while(right < nums.Length) {
            sum += nums[right] % 2;

            while(sum > k) {
                sum -= nums[left] % 2;
                left++;
            }

            result = result + (right - left + 1);
            right++;
        }

        return result;
    }
}
// @lc code=end

