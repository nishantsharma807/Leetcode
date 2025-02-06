/*
 * @lc app=leetcode id=1358 lang=csharp
 *
 * [1358] Number of Substrings Containing All Three Characters
 */

// @lc code=start
public class Solution {
    public int NumberOfSubstrings(string s) {
        int result = 0;
        int[] arr = new int[] { -1, -1, -1 };

        for(int i = 0; i < s.Length; i++) {
            int idx = s[i] - 'a';
            arr[idx] = i;

            if(arr[0] >= 0 && arr[1] >= 0 && arr[2] >= 0) {
                int minIdx = Math.Min(arr[0], Math.Min(arr[1], arr[2]));
                result = result + minIdx + 1;
            }
        }

        return result;
    }
}
// @lc code=end

