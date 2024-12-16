/*
 * @lc app=leetcode id=13 lang=csharp
 *
 * [13] Roman to Integer
 */

// @lc code=start
public class Solution {
    public int RomanToInt(string s) {
        var map = new Dictionary<char, int>() 
        {
            { 'I', 1 }, { 'V', 5 }, { 'X', 10 }, { 'L', 50 },
            { 'C', 100 }, { 'D', 500 }, { 'M', 1000 }
        };

        int prev = 0;
        int result = 0;

        for(int i = s.Length - 1; i >= 0; i--) {
            int curr = map[s[i]];

            if(curr < prev) {
                result = result - prev + (prev - curr);
            }
            else {
                result += curr;
            }

            prev = curr;
        }

        return result;
    }
}
// @lc code=end

