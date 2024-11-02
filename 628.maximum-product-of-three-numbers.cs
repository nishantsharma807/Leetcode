/*
 * @lc app=leetcode id=628 lang=csharp
 *
 * [628] Maximum Product of Three Numbers
 */

// @lc code=start
public class Solution
{
    public int MaximumProduct(int[] nums)
    {
        //O(nlogn)
        // Array.Sort(nums);          
        // return Math.Max(nums[0] * nums[1] * nums[nums.Length - 1], 
        // nums[nums.Length - 1] * nums[nums.Length - 2] * nums[nums.Length - 3]);


        //O(n)
        int min1 = int.MaxValue,
        min2 = int.MaxValue,
        max1 = int.MinValue,
        max2 = int.MinValue,
        max3 = int.MinValue;

        foreach (int n in nums)
        {
            if (min1 >= n)
            {
                min2 = min1;
                min1 = n;
            }
            else if (min2 >= n)
            {
                min2 = n;
            }

            if (n >= max1)
            {
                max3 = max2;
                max2 = max1;
                max1 = n;
            }
            else if (n >= max2)
            {
                max3 = max2;
                max2 = n;
            }
            else if (n >= max3)
            {
                max3 = n;
            }
        }

        return Math.Max(min1 * min2 * max1, max1 * max2 * max3);
    }
}
// @lc code=end

