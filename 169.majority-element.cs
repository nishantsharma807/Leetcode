/*
 * @lc app=leetcode id=169 lang=csharp
 *
 * [169] Majority Element
 */

// @lc code=start
public class Solution {
    public int MajorityElement(int[] nums) {
        var majorityElement = 0;
        var count = 0;

        foreach(int num in nums) {
            if(count == 0) majorityElement = num;

            if(majorityElement == num) count++;
            else count--;
        }

        return majorityElement;
    }
}
// @lc code=end

