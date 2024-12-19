/*
 * @lc app=leetcode id=1189 lang=csharp
 *
 * [1189] Maximum Number of Balloons
 */

// @lc code=start
public class Solution {
    public int MaxNumberOfBalloons(string text) {
        var map = new Dictionary<char, int>();

        foreach(char c in text) {
            if(!map.ContainsKey(c)) map.Add(c, 1);
            else map[c] += 1;
        }

        bool continueSearch = true;
        int result = 0;

        while(continueSearch) {
            foreach(char c in "balloon") {
                if(map.ContainsKey(c)) {
                    map[c] -= 1;
                    if(map[c] == 0) map.Remove(c);
                }
                else {
                    continueSearch = false;
                    break;
                }
            }

            if(continueSearch) result++;
        }

        return result;
    }
}
// @lc code=end

