/*
 * @lc app=leetcode id=121 lang=csharp
 *
 * [121] Best Time to Buy and Sell Stock
 */

// @lc code=start
public class Solution {
    public int MaxProfit(int[] prices) {
        int minBuy = Int32.MaxValue, maxProfit = 0;
        
        for(int i = 0; i < prices.Length; i++) {
            if(prices[i] < minBuy) 
                minBuy = prices[i];
            else if (prices[i] - minBuy > maxProfit)
                maxProfit = prices[i] - minBuy;
        }

        return maxProfit;
    }
}
// @lc code=end

