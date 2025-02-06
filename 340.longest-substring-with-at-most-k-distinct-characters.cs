/*
 * @lc app=leetcode id=340 lang=csharp
 *
 * [340] Longest Substring with At Most K Distinct Characters
 */

// @lc code=start
public class Solution {
    public int LengthOfLongestSubstringKDistinct(string s, int k) {
        int result = 0, left = 0, right = 0;
        var map = new Dictionary<char, int>();

        while(right < s.Length) {
            if(map.ContainsKey(s[right])) map[s[right]] += 1;
            else map.Add(s[right], 1);

            if(map.Count > k) {
                map[s[left]] -= 1;
                if(map[s[left]] == 0) map.Remove(s[left]);
                left++;
            } else {
                result = Math.Max(result, right - left + 1);
            }

            right++;
        }

        return result;
    }
}
// @lc code=end

