/*
 * @lc app=leetcode id=575 lang=csharp
 *
 * [575] Distribute Candies
 */

// @lc code=start
public class Solution {
    public int DistributeCandies(int[] candyType) {
        var hashCandies = new HashSet<int>(candyType);
        var maxAllowed = candyType.Length / 2;

        if(maxAllowed <= hashCandies.Count) return maxAllowed;
        else return hashCandies.Count;
    }
}
// @lc code=end

