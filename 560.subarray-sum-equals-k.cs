/*
 * @lc app=leetcode id=560 lang=csharp
 *
 * [560] Subarray Sum Equals K
 */

// @lc code=start
public class Solution {
    public int SubarraySum(int[] nums, int k) {
        int result = 0, prefixSum = 0;
        var map = new Dictionary<int, int>();
        map.Add(0, 1);

        for(int i = 0; i < nums.Length; i++) {
            prefixSum += nums[i];
            var diff = prefixSum - k;

            if(map.ContainsKey(diff)) {
                result += map[diff];
            }

            if(map.ContainsKey(prefixSum)) map[prefixSum] += 1;
            else map.Add(prefixSum, 1);
        }

        return result;
    }
}
// @lc code=end

