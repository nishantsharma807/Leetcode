/*
 * @lc app=leetcode id=598 lang=csharp
 *
 * [598] Range Addition II
 */

// @lc code=start
public class Solution {
    public int MaxCount(int m, int n, int[][] ops) {
        foreach(int[] op in ops) {
            m = Math.Min(m, op[0]);
            n = Math.Min(n, op[1]);
        }
        
        return m * n;
    }
}
// @lc code=end

