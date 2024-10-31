/*
 * @lc app=leetcode id=594 lang=csharp
 *
 * [594] Longest Harmonious Subsequence
 */

// @lc code=start
public class Solution {
    public int FindLHS(int[] nums) {
        int maxLength = 0;
        var mapNums = new Dictionary<int, int>();

        foreach(int num in nums) {
            if(!mapNums.ContainsKey(num)) {
                mapNums.Add(num, 0);
            }

            mapNums[num] += 1;
        }

        if(mapNums.Count == 1) return 0;
        
        foreach(KeyValuePair<int, int> kvp in mapNums) {
            if(mapNums.ContainsKey(kvp.Key + 1)) {
                int currentLength = kvp.Value;
                currentLength += mapNums[kvp.Key + 1];
                maxLength = Math.Max(maxLength, currentLength);
            }
        }

        return maxLength;
    }
}
// @lc code=end

