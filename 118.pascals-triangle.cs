/*
 * @lc app=leetcode id=118 lang=csharp
 *
 * [118] Pascal's Triangle
 */

// @lc code=start
public class Solution {
    public IList<IList<int>> Generate(int numRows) {
        IList<IList<int>> result = new List<IList<int>>();

        for(int i = 0; i < numRows; i++) {
            var currList = new List<int>();

            for(int j = 0; j <= i; j++) {
                var currValue = 1;
                
                if(j > 0 && j < i) {
                    var rowAbove = result[i -1];
                    currValue = rowAbove[j - 1] + rowAbove[j];
                }
                
                currList.Add(currValue);
            }

            result.Add(currList);
        }

        return result;        
    }
}
// @lc code=end

