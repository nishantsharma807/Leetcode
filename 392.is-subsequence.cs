/*
 * @lc app=leetcode id=392 lang=csharp
 *
 * [392] Is Subsequence
 */

// @lc code=start
public class Solution {
    public bool IsSubsequence(string s, string t) {
        int sPointer = 0, tPointer = 0;

        while(tPointer < t.Length && sPointer < s.Length) {
            if(s[sPointer] == t[tPointer]) {
                sPointer++;
                tPointer++;
            }
            else {
                tPointer++;
            }
        }

        return sPointer == s.Length;
    }
}
// @lc code=end

