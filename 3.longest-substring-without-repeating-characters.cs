/*
 * @lc app=leetcode id=3 lang=csharp
 *
 * [3] Longest Substring Without Repeating Characters
 */

// @lc code=start
public class Solution {
    public int LengthOfLongestSubstring(string s) {
        var map = new Dictionary<char, int>();
        int result = 0, left = 0, right = 0;

        if(s.Length == 0) return result;

        while(right < s.Length) {
            if(map.ContainsKey(s[right])) {
                left = Math.Max(map[s[right]] + 1, left);
                map[s[right]] = right;
            }
            else {
                map.Add(s[right], right);
            }
            
            result = Math.Max(result, right - left + 1);
            right++;
        }

        return result;
    }
}
// @lc code=end

