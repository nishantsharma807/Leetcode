/*
 * @lc app=leetcode id=414 lang=csharp
 *
 * [414] Third Maximum Number
 */

// @lc code=start
public class Solution {
    public int ThirdMax(int[] nums) {
        var setNums = new SortedSet<int>(nums);
        return setNums.Count < 3 ? setNums.Last() : setNums.ElementAt(setNums.Count - 3);
    }
}
// @lc code=end

