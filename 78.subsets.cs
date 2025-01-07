/*
 * @lc app=leetcode id=78 lang=csharp
 *
 * [78] Subsets
 */

// @lc code=start
public class Solution {
    public IList<IList<int>> Subsets(int[] nums) {
        var result = new List<IList<int>>();

        FindSubsequences(0, nums, new List<int>(), result);

        return result;
    }

    private void FindSubsequences(int index, int[] nums, IList<int> record, List<IList<int>> result) {        
        result.Add(new List<int>(record));

        for(int i = index; i < nums.Length; i++) {
            record.Add(nums[i]);
            FindSubsequences(i + 1, nums, record, result);
            record.RemoveAt(record.Count - 1);
        }      
    }
}
// @lc code=end

