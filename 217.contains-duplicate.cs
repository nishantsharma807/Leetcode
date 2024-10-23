/*
 * @lc app=leetcode id=217 lang=csharp
 *
 * [217] Contains Duplicate
 */

// @lc code=start
public class Solution {
    public bool ContainsDuplicate(int[] nums) {
        var numsSet = new HashSet<int>();

        foreach(int num in nums) {
            if(numsSet.Contains(num)) return true;
            else numsSet.Add(num);
        }

        return false;
    }
}
// @lc code=end

