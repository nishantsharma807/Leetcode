/*
 * @lc app=leetcode id=167 lang=csharp
 *
 * [167] Two Sum II - Input Array Is Sorted
 */

// @lc code=start
public class Solution {
    public int[] TwoSum(int[] numbers, int target) {
        int left = 0, right = numbers.Length - 1;

        while(left < right) {
            int sum = numbers[left] + numbers[right];
            
            if(sum == target) {
                return new int[] { left + 1, right + 1 };
            } 
            else if(sum > target) {
                 right--;
            }
            else {
                left++;
            }
        }

        return new int[] {};
    }
}
// @lc code=end

