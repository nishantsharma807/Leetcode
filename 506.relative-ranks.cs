/*
 * @lc app=leetcode id=506 lang=csharp
 *
 * [506] Relative Ranks
 */

// @lc code=start
public class Solution {
    public string[] FindRelativeRanks(int[] score) {
        var result = new List<string>();
        var sortedScores = score.OrderByDescending(x => x).ToList();
        var hashSetScores = new Hashtable();

        for(int i = 0; i < sortedScores.Count; i++) {
            hashSetScores.Add(sortedScores[i], i + 1);
        }

        for(int i = 0; i < score.Length; i++) {
            var scoreValue = hashSetScores[score[i]].ToString();            
            var position = scoreValue.ToString();

            if(scoreValue == "1") {
                position = "Gold Medal";
            }
            else if(scoreValue == "2") {
                position = "Silver Medal";
            }
            else if(scoreValue == "3") {
                position = "Bronze Medal";
            }

            result.Add(position);
        }

        return result.ToArray();
    }
}
// @lc code=end

