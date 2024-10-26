/*
 * @lc app=leetcode id=219 lang=csharp
 *
 * [219] Contains Duplicate II
 */

// @lc code=start
public class Solution {
    public bool ContainsNearbyDuplicate(int[] nums, int k) {
        var numsDict = new Dictionary<int, List<int>>();

        for(int i = 0; i < nums.Length; i++) {
            if(numsDict.ContainsKey(nums[i])) {
                var indexes = numsDict[nums[i]];
                //Check last element added
                if(Math.Abs(indexes[indexes.Count -1] - i) <= k) return true;

                numsDict[nums[i]].Add(i);
            } else {
                numsDict.Add(nums[i], new List<int>() { i });
            }
        }

        return false;
    }
}
// @lc code=end

