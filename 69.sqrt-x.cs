/*
 * @lc app=leetcode id=69 lang=csharp
 *
 * [69] Sqrt(x)
 */

// @lc code=start
public class Solution {
    public int MySqrt(int x) {
        if(x == 0) return 0;

        int result = 1, low = 1, high = x;

        while(low <= high) {
            int mid = low + (high - low) / 2;
            long val = (long)mid * mid;

            if(val <= x) {
                low = mid + 1;
                result = mid;
            }
            else {
                high = mid - 1;
            }
        }

        return result;
    }
}
// @lc code=end

