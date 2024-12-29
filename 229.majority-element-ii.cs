/*
 * @lc app=leetcode id=229 lang=csharp
 *
 * [229] Majority Element II
 */

// @lc code=start
public class Solution {
    public IList<IList<int>> Permute(int[] nums) {
        int element1 = -1, element2 = -1;
        int counter1 = 0, counter2 = 0;
        var result = new List<int>();

        foreach(int num in nums) {
            if(counter1 == 0 && num != element2) {
                element1 = num;
                counter1++;
            }
            else if(counter2 == 0 && num != element1) {
                element2 = num;
                counter2++;
            }
            else if(num == element1) counter1++;
            else if(num == element2) counter2++;
            else{
                counter1--;
                counter2--;
            }
        }

        counter1 = 0;
        counter2 = 0;

        foreach(int num in nums) {
            if(num == element1) counter1++;
            else if(num == element2) counter2++;
        }

        if(counter1 > nums.Length / 3) result.Add(element1);
        if(counter2 > nums.Length / 3) result.Add(element2);

        return result;
    }
}
// @lc code=end

