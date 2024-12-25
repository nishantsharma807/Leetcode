/*
 * @lc app=leetcode id=189 lang=csharp
 *
 * [189] Rotate Array
 */

// @lc code=start
public class Solution {
    public void Rotate(int[] nums, int k) {
        int rotations = k % nums.Length;

            Reverse(nums, 0, nums.Length - 1);
            Reverse(nums, 0, rotations - 1);
            Reverse(nums, rotations, nums.Length - 1);
        }
    }

    private void Reverse(int[] nums, int start, int end) {
        while (start < end) {
            int temp = nums[start];
            nums[start] = nums[end];
            nums[end] = temp;
            start++;
            end--;
        }
    }
}
// @lc code=end

