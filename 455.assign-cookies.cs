/*
 * @lc app=leetcode id=455 lang=csharp
 *
 * [455] Assign Cookies
 */

// @lc code=start
public class Solution {
    public int FindContentChildren(int[] g, int[] s) {
        Array.Sort(g);
        Array.Sort(s);

        int contentChildren = 0;
        int cookieIndex = 0;

        while (cookieIndex < s.Length && contentChildren < g.Length) {
            if (s[cookieIndex] >= g[contentChildren]) {
                contentChildren++;
            }
            cookieIndex++;
        }

        return contentChildren;
    }
}
// @lc code=end

