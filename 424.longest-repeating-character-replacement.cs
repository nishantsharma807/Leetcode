/*
 * @lc app=leetcode id=424 lang=csharp
 *
 * [424] Longest Repeating Character Replacement
 */

// @lc code=start
public class Solution {
    public int CharacterReplacement(string s, int k) {
        int result = 0, left = 0, right = 0, maxFrequency = 0;
        var map = new Dictionary<char, int>();

        while(right < s.Length) {
            if(map.ContainsKey(s[right])) map[s[right]] +=1;
            else map.Add(s[right], 1);

            maxFrequency = Math.Max(maxFrequency, map[s[right]]);

            if(right - left + 1 - maxFrequency > k) {
                map[s[left]]--;              
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

