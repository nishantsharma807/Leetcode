/*
 * @lc app=leetcode id=70 lang=csharp
 *
 * [70] Climbing Stairs
 */

// @lc code=start
public class Solution {
    public int ClimbStairs(int n) {
        if(n <= 1) return 1;
        
        int first = 1, second = 2;

        for(int i = 3; i <= n; i++) {
            int curr = first + second;
            first = second;
            second = curr;
        }

        return second;
    }
}
// @lc code=end

