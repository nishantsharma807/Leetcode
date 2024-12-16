/*
 * @lc app=leetcode id=246 lang=csharp
 *
 * [246] Strobogrammatic Number
 */

// @lc code=start
public class Solution {
    public bool IsStrobogrammatic(string num) {
        var map = new Dictionary<char, char>()
        {
            {'0', '0'}, {'1', '1'}, {'6', '9'}, {'8', '8'}, {'9', '6'}
        };

        int left = 0, right = num.Length - 1;

        while(left <= right) {
            if(!map.ContainsKey(num[left]) || map[num[left]] != num[right]) return false;

            left++;
            right--;
        }

        return true;
    }
}
// @lc code=end

