/*
 * @lc app=leetcode id=448 lang=csharp
 *
 * [448] Find All Numbers Disappeared in an Array
 */

// @lc code=start
public class Solution {
    public IList<int> FindDisappearedNumbers(int[] nums) {
        var result = new List<int>();
        var setNums = new HashSet<int>(nums);

        for(int i = 1; i <= nums.Length; i++) {
            if(!setNums.Contains(i))
                result.Add(i);
        }

        return result;
    }
}
// @lc code=end

