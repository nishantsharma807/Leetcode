/*
 * @lc app=leetcode id=2239 lang=csharp
 *
 * [2239] Find Closest Number to Zero
 */

// @lc code=start
public class Solution {
    public int FindClosestNumber(int[] nums) {
        int distance = Int32.MaxValue, result = Int32.MinValue;

        foreach(int num in nums) {
            int currDistance = Math.Abs(num - 0);
            
            if(currDistance < distance) {
                distance = currDistance;
                result = num; 
            }
            else if (currDistance == distance) {
                result = Math.Max(result, num);
            }
        }

        return result;
    }
}
// @lc code=end

