/*
 * @lc app=leetcode id=496 lang=csharp
 *
 * [496] Next Greater Element I
 */

// @lc code=start
public class Solution {
    public int[] NextGreaterElement(int[] nums1, int[] nums2) {
        int[] result = new int[nums1.Length];
        var map = new Dictionary<int, int>();
        Stack<int> stack = new Stack<int>();
    
        for(int i = nums2.Length - 1; i >= 0; i--) {
            while(stack.Count > 0 && stack.Peek() < nums2[i]) {
                stack.Pop();
            }

            if(stack.Count == 0) map.Add(nums2[i], -1);
            else map.Add(nums2[i], stack.Peek());

            stack.Push(nums2[i]);
        }

        for(int i = 0; i < nums1.Length; i++) {
            result[i] = map[nums1[i]];
        }
        
        return result;
    }
}
// @lc code=end

