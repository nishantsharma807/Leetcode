/*
 * @lc app=leetcode id=121 lang=csharp
 *
 * [121] Best Time to Buy and Sell Stock
 */

// @lc code=start
public class Solution {
    public int MaxProfit(int[] prices) {
        int result = 0;
        int buy = int.MaxValue;

        for(int i = 0; i < prices.Length; i++) {
            if(buy > prices[i]) {
                buy = prices[i];
            }
            else if(prices[i] - buy > result) {
                 result = prices[i] - buy;
            }
        }

        return result;  
    }
}
// @lc code=end

