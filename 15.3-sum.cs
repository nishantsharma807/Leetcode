/*
 * @lc app=leetcode id=15 lang=csharp
 *
 * [15] 3Sum
 */

// @lc code=start
public class Solution {
    public IList<IList<int>> ThreeSum(int[] nums) {
        Array.Sort(nums);
        //var set = new HashSet<string>();
        var result = new List<IList<int>>();

        for(int i = 0; i < nums.Length - 2; i++) {
            if(i > 0 && nums[i] == nums[i - 1]) continue;
            int j = i + 1;
            int k = nums.Length - 1;

            while(j < k) {
                int sum = nums[i] + nums[j] + nums[k];

                if(sum > 0) {
                    k--;
                } else if (sum < 0) {
                    j++;
                }
                else {
                    result.Add(new List<int> { nums[i], nums[j], nums[k] });
                    j++;
                    k--;
                    while(j < k && nums[j] == nums[j - 1]) j++;
                    while(j < k && nums[k] == nums[k + 1]) k--;
                }
            }
        }

        // for(int i = 0; i < nums.Length; i++) {
        //     var setNums = new HashSet<int>();
        //     for(int j = i + 1; j < nums.Length; j++) {
        //         var element = - (nums[i] + nums[j]);
        //         if(setNums.Contains(element)) {
        //             var record = new List<int>() { nums[i], nums[j], element };
        //             record.Sort();
        //             string key = string.Join(",", record);
        //             if (set.Add(key)) result.Add(record);
        //         } else {
        //             setNums.Add(nums[j]);
        //         }
        //     }
        // }

        // for(int i = 0; i < nums.Length; i++) {
        //     for(int j = i + 1; j < nums.Length; j++) {
        //         for(int k = j + 1; k < nums.Length; k++) {
        //             if(nums[i] + nums[j] + nums[k] == 0) {
        //                 var record = new List<int>() { nums[i], nums[j], nums[k] };
        //                 record.Sort();
        //                 string key = string.Join(",", record);
        //                 if (set.Add(key))
        //                 {
        //                     result.Add(record);
        //                 }
        //             }
        //         }
        //     }
        // }

        return result;
    }
}
// @lc code=end

