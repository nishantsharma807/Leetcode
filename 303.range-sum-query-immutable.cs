/*
 * @lc app=leetcode id=303 lang=csharp
 *
 * [303] Range Sum Query - Immutable
 */

// @lc code=start
public class NumArray {
    private readonly int[] nums;

    public NumArray(int[] nums) {
        this.nums = nums;
    }
    
    public int SumRange(int left, int right) {
        int sum = 0;

        while(left <= right) {
            sum += nums[left];
            left++;
        }

        return sum;
    }
}

/**
 * Your NumArray object will be instantiated and called as such:
 * NumArray obj = new NumArray(nums);
 * int param_1 = obj.SumRange(left,right);
 */
// @lc code=end

