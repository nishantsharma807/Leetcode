/*
 * @lc app=leetcode id=383 lang=csharp
 *
 * [383] Ransom Note
 */

// @lc code=start
public class Solution {
    public bool CanConstruct(string ransomNote, string magazine) {
        var map = new Dictionary<char, int>();

        foreach(char c in magazine) {
            if(!map.ContainsKey(c)) map.Add(c, 1);
            else map[c] += 1;
        }

        foreach(char c in ransomNote) {
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

