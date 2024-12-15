/*
 * @lc app=leetcode id=1679 lang=csharp
 *
 * [1679] Max Number of K-Sum Pairs
 */

// @lc code=start
public class Solution {
    public int MaxOperations(int[] nums, int k) {
        int result = 0;
        var map = new Dictionary<int, int>();
        
        for(int i = 0; i < nums.Length; i++) {
            int diff = k - nums[i];

            if(map.ContainsKey(diff)) {
                map[diff] -= 1;
                result++;
                if(map[diff] == 0) map.Remove(diff);
            }
            else {
                if(!map.ContainsKey(nums[i])) map.Add(nums[i], 1);
                else map[nums[i]] += 1;
            }
        }

        return result;
    }
}
// @lc code=end

