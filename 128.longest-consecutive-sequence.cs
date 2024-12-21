/*
 * @lc app=leetcode id=128 lang=csharp
 *
 * [128] Longest Consecutive Sequence
 */

// @lc code=start
public class Solution {
    public int LongestConsecutive(int[] nums) {
        int result = 0;
        var set = new HashSet<int>(nums);

        foreach(int num in nums) {
            if(!set.Contains(num - 1)) {
                int currNum = num;
                int currResult = 1;

                while(set.Contains(currNum + 1)) {
                    currNum += 1;
                    currResult += 1;
                }

                result = Math.Max(result, currResult);
            }
        }

        return result;
    }
}
// @lc code=end

