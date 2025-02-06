/*
 * @lc app=leetcode id=992 lang=csharp
 *
 * [992] Subarrays with K Different Integers
 */

// @lc code=start
public class Solution {
    public int SubarraysWithKDistinct(int[] nums, int k) {
        return Subarrays(nums, k) - Subarrays(nums, k - 1);
    }

    private int Subarrays(int[] nums, int k) {
        if(k < 0) return 0;

        int left = 0, right = 0, result = 0;
        var freqMap = new Dictionary<int, int>();

        while(right < nums.Length) {
            if(freqMap.ContainsKey(nums[right])) freqMap[nums[right]] += 1;
            else freqMap.Add(nums[right], 1);

            while(freqMap.Count > k) {
                freqMap[nums[left]] -= 1;
                if(freqMap[nums[left]] == 0) freqMap.Remove(nums[left]);
                left++;
            }

            result = result + (right - left + 1);
            right++;
        }

        return result;
    }
}
// @lc code=end

