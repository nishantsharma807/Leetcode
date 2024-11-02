/*
 * @lc app=leetcode id=682 lang=csharp
 *
 * [682] Baseball Game
 */

// @lc code=start
public class Solution {
    public int CalPoints(string[] operations) {
        var records = new List<int>();
        int sum = 0;

        for(int i = 0; i < operations.Length; i++) {
            int lastRecord = records.Count - 1;

            if(operations[i] == "C") {
                if(lastRecord >= 0) {
                    sum -= records.ElementAt(lastRecord);
                    records.RemoveAt(lastRecord);
                }
            }
            else if (int.TryParse(operations[i], out int rec)) {
                records.Add(rec);
                sum += rec;
            }
            else if (operations[i] == "D") {
                records.Add(records[lastRecord] * 2);
                sum += (records[lastRecord] * 2);
            }
            else if (operations[i] == "+") {
                if (lastRecord == 0) {
                    records.Add(records[lastRecord]);
                    sum += records[lastRecord];
                }
                else 
                {
                    var lastTwoSum = records[lastRecord] + records[lastRecord -1];
                    records.Add(lastTwoSum);
                    sum += lastTwoSum;
                }
            }
        }

        return sum;
    }
}
// @lc code=end

