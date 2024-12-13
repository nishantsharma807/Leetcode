/*
 * @lc app=leetcode id=1431 lang=csharp
 *
 * [1431] Kids With the Greatest Number of Candies
 */

// @lc code=start
public class Solution {
    public IList<bool> KidsWithCandies(int[] candies, int extraCandies) {
        IList<bool> result = new List<bool>();
        int maxCandies = candies.Max();

        for(int i = 0; i < candies.Length; i++) {
            result.Add(candies[i] + extraCandies >= maxCandies);
        }

        return result;
    }
}
// @lc code=end

