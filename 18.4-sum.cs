/*
 * @lc app=leetcode id=18 lang=csharp
 *
 * [18] 4Sum
 */

// @lc code=start
public class Solution {
    public IList<IList<int>> FourSum(int[] nums, int target) {
        var result = new List<IList<int>>();

        Array.Sort(nums);

        for(int i = 0; i < nums.Length - 3; i++) {
            if(i > 0 && nums[i] == nums[i - 1]) continue;
            for(int j = i + 1; j < nums.Length - 2; j++) {
                if(j > i + 1 && nums[j] == nums[j - 1]) continue;
                int left = j + 1;
                int right = nums.Length - 1;

                while(left < right) {
                    long sum = (long)nums[i] + (long)nums[j] + (long)nums[left] + (long)nums[right];

                    if(sum > target) right--;
                    else if(sum < target) left++;
                    else {
                        result.Add(new List<int>() { nums[i], nums[j], nums[left], nums[right] });
                        left++;
                        right--;
                        while(left < right && nums[left] == nums[left - 1]) left++;
                        while(left < right && nums[right] == nums[right + 1]) right--;
                    }
                }
            }
        }


        // var set = new HashSet<string>();

        // for(int i = 0; i < nums.Length; i++) {
        //     for(int j = i + 1; j < nums.Length; j++) {
        //         var setNums = new HashSet<long>();
        //         for(int k = j + 1; k < nums.Length; k++) {
        //             long element = (long)target - (long)nums[i] - (long)nums[j] - (long)nums[k];

        //             if(setNums.Contains(element)) {
        //                 var record = new List<int>() { nums[i], nums[j], nums[k], (int)element };
        //                 record.Sort();
        //                 var uniqueKey = string.Join(",", record);
        //                 if(set.Add(uniqueKey)) result.Add(record);
        //             } else {
        //                 setNums.Add(nums[k]);
        //             }
        //         }
        //     }
        // }

        return result;
    }
}
// @lc code=end

