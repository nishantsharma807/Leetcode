/*
 * @lc app=leetcode id=11 lang=csharp
 *
 * [11] Container With Most Water
 */

// @lc code=start
public class Solution {
    public int MaxArea(int[] height) {
        int maxArea = 0;
        int i = 0, j = height.Length - 1;
        
        while(i < j) {
            var minHeight = Math.Min(height[i], height[j]);
            maxArea = Math.Max(maxArea, minHeight * (j-i));

            if(height[i] > height[j]) j--;
            else i++;
        }

        return maxArea;
    }
}
// @lc code=end

