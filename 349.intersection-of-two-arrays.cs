/*
 * @lc app=leetcode id=349 lang=csharp
 *
 * [349] Intersection of Two Arrays
 */

// @lc code=start
public class Solution {
    public int[] Intersection(int[] nums1, int[] nums2) {
        var setResult = new HashSet<int>();
        var setNums2 = new HashSet<int>(nums2);
        
        for(int i = 0; i < nums1.Length; i++) {
            if(setNums2.Contains(nums1[i]))
                setResult.Add(nums1[i]);
        }

        return setResult.ToArray();
    }
}
// @lc code=end

