/*
 * @lc app=leetcode id=66 lang=csharp
 *
 * [66] Plus One
 */

// @lc code=start
public class Solution {
    public int[] PlusOne(int[] digits) {
        var lastIdx = digits.Length - 1;

        while(lastIdx >= 0) {
            if(digits[lastIdx] == 9) {
                digits[lastIdx] = 0;
                lastIdx--;                
            } else {
                digits[lastIdx] += 1;
                break;
            }
        }

        //All digits were nine
        if(digits[0] == 0) {
            return new int[] {1}.Concat(digits).ToArray();
        }

        return digits;    
    }
}
// @lc code=end

