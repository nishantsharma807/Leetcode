/*
 * @lc app=leetcode id=560 lang=csharp
 *
 * [560] Subarray Sum Equals K
 */

// @lc code=start
public class Solution {
    public int SubarraySum(int[] nums, int k) {
        int result = 0, sum = 0;
        var map = new Dictionary<int, int>();
        map.Add(0, 1);
        
        for(int i = 0; i < nums.Length; i++) {
            sum += nums[i];

            if(map.ContainsKey(sum - k)) {
                result += map[sum - k];
            }

            if(map.ContainsKey(sum)) map[sum] += 1;
            else map.Add(sum, 1);
        }

        return result;
    }
}
// @lc code=end

