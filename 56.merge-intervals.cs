/*
 * @lc app=leetcode id=56 lang=csharp
 *
 * [56] Merge Intervals
 */

// @lc code=start
public class Solution {
    public int[][] Merge(int[][] intervals) {
        var result = new List<List<int>>();
        
        Array.Sort(intervals, (a, b) => a[0] - b[0]);

        foreach(int[] interval in intervals) {
            if(result.Count == 0 || result.Last()[1] < interval[0]) {
                result.Add(new List<int>() { interval[0], interval[1] });
            } else {
                result.Last()[1] = Math.Max(result.Last()[1], interval[1]);
            }
        }

        return result.Select(x => x.ToArray()).ToArray();
    }
}
// @lc code=end

