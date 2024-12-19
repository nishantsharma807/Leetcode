/*
 * @lc app=leetcode id=228 lang=csharp
 *
 * [228] Summary Ranges
 */

// @lc code=start
public class Solution {
    public IList<string> SummaryRanges(int[] nums) {
        var result = new List<string>();
        if (nums.Length == 0) return result;
        
        int prev = nums[0], start = nums[0];

        for(int i = 1; i < nums.Length; i++) {
            if(nums[i] - 1 == prev) {
                prev = nums[i];
            }
            else {
                if(start == prev) result.Add($"{start}");
                else result.Add($"{start}->{prev}");
                prev = nums[i];
                start = nums[i];
            }
        }

        if(start == prev) result.Add($"{start}");
        else result.Add($"{start}->{prev}");

        return result;
    }
}
// @lc code=end

