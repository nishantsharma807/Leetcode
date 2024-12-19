/*
 * @lc app=leetcode id=242 lang=csharp
 *
 * [242] Valid Anagram
 */

// @lc code=start
public class Solution {
    public bool IsAnagram(string s, string t) {
        if(s.Length != t.Length) return false;
        var map = new Dictionary<char, int>();

        foreach(char c in s) {
            if(!map.ContainsKey(c)) map.Add(c, 1);
            else map[c] += 1;
        }

        foreach(char c in t) {
            if(map.ContainsKey(c)) {
                map[c] -= 1;
                if(map[c] == 0) map.Remove(c);
            }
            else {
                return false;
            }
        }

        return true;
    }
}
// @lc code=end

