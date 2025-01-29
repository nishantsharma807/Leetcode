/*
 * @lc app=leetcode id=50 lang=csharp
 *
 * [50] Pow(x, n)
 */

// @lc code=start
public class Solution {
    public double MyPow(double x, int n) {
        long nn = (long) n;

        if(nn == 0) return 1;

        if(nn < 1) {
            nn = nn * -1;
            x = 1.0 / x;
        }

        double result = 1;

        while(nn != 0) {
            if (nn % 2 == 1) {
                result *= x;
                nn -= 1;
            } else {
                x *= x;
                nn /= 2;
            }
        }

        return result;
    }
}
// @lc code=end

