/*
 * @lc app=leetcode id=503 lang=csharp
 *
 * [503] Next Greater Element II
 */

// @lc code=start
public class Solution {
    public int[] NextGreaterElements(int[] nums) {
        var result = new int[nums.Length];
        Stack<int> stack = new Stack<int>();

        for(int i = (2 * nums.Length) - 1; i >= 0; i--) {
            while(stack.Count > 0 && stack.Peek() <= nums[i % nums.Length]) {
                stack.Pop();
            }

            if(i < nums.Length) {
                result[i] = stack.Count == 0 ? -1 : stack.Peek();
            }

            stack.Push(nums[i % nums.Length]);
        }

        return result;
    }
}
// @lc code=end

