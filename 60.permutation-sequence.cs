/*
 * @lc app=leetcode id=60 lang=csharp
 *
 * [60] Permutation Sequence
 */

// @lc code=start
public class Solution {
    public string GetPermutation(int n, int k) {
        int fact = 1;
        var nums = new List<int>();

        for(int i = 1; i <= n; i++) {
            nums.Add(i);
            if(i != n) fact *= i;
        }
        
        k = k - 1;

        StringBuilder sb = new StringBuilder();

        while(nums.Count > 0) {
            int index = k / fact;
            sb.Append(nums[index]);
            nums.RemoveAt(index);

            if(nums.Count == 0) break;

            k = k % fact;
            fact = fact / nums.Count;
        }

        return sb.ToString();
    }
}
// @lc code=end

