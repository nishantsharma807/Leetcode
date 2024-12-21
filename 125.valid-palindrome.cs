/*
 * @lc app=leetcode id=125 lang=csharp
 *
 * [125] Valid Palindrome
 */

// @lc code=start
public class Solution {
    public bool IsPalindrome(string s) {
        int left = 0, right = s.Length - 1;

        while(left < right) {
            while (left < right && !Char.IsLetterOrDigit(s[left])) {
                left++;
            }

            while (left < right && !Char.IsLetterOrDigit(s[right])) {
                right--;
            }

            if(char.ToLower(s[left]) != char.ToLower(s[right])) return false;

            left++;
            right--;
        }

        return true;
    }
}
// @lc code=end

