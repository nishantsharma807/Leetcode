/*
 * @lc app=leetcode id=599 lang=csharp
 *
 * [599] Minimum Index Sum of Two Lists
 */

// @lc code=start
public class Solution {
    public string[] FindRestaurant(string[] list1, string[] list2) {
        int leastSum = int.MaxValue;
        var mapWords = new Dictionary<string, Tuple<int, bool>>();

        for(int i = 0; i < list1.Length; i++) {
            if(!mapWords.ContainsKey(list1[i])) {
                mapWords.Add(list1[i], Tuple.Create(i, false));
            }
        }

        for(int i = 0; i < list2.Length; i++) {
            if(mapWords.ContainsKey(list2[i])) {
                var prevIdx = mapWords[list2[i]].Item1;
                leastSum = Math.Min(leastSum, (prevIdx + i));
                
                mapWords[list2[i]] = Tuple.Create(prevIdx + i, true);
            }
        }

        return mapWords.Where(x => x.Value.Item2 && x.Value.Item1 == leastSum).ToList().Select(x => x.Key).ToArray();
    }
}
// @lc code=end

