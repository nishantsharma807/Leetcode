/*
 * @lc app=leetcode id=350 lang=csharp
 *
 * [350] Intersection of Two Arrays II
 */

// @lc code=start
public class Solution {
    public int[] Intersect(int[] nums1, int[] nums2) {
        var setResult = new List<int>();
        var setNums2 = new List<int>(nums2);
        
        for(int i = 0; i < nums1.Length; i++) {
            if(setNums2.Contains(nums1[i])) {
                setResult.Add(nums1[i]);
                setNums2.Remove(nums1[i]);
            }
        }

        return setResult.ToArray();
    }
}
// @lc code=end

