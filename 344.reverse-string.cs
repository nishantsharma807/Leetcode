/*
 * @lc app=leetcode id=344 lang=csharp
 *
 * [344] Reverse String
 */

// @lc code=start
public class Solution {
    public void ReverseString(char[] s) {
        int left = 0, right = s.Length - 1;

        while(left < right) {
            var temp = s[right];
            s[right] = s[left];
            s[left] = temp;
            left++;
            right--;
        }
    }
}
// @lc code=end

