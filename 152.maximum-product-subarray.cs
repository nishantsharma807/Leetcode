/*
 * @lc app=leetcode id=152 lang=csharp
 *
 * [152] Maximum Product Subarray
 */

// @lc code=start
public class Solution {
    public int MaxProduct(int[] nums) {
        int result = Int32.MinValue;
        int prefixProduct = 1, suffixProduct = 1;

        for(int i = 0; i < nums.Length; i++) {
            if(prefixProduct == 0) prefixProduct = 1;
            if(suffixProduct == 0) suffixProduct = 1;
            
            prefixProduct *= nums[i];
            suffixProduct *= nums[nums.Length - i - 1];

            result = Math.Max(result, Math.Max(prefixProduct, suffixProduct));
        }

        return result;
    }
}
// @lc code=end

