/*
 * @lc app=leetcode id=252 lang=csharp
 *
 * [252] Meeting Rooms
 */

// @lc code=start
public class Solution {
    public bool CanAttendMeetings(int[][] intervals) {
        if(intervals.Length < 2) return true;

        var data = intervals.OrderBy(entry => entry[0]).ToArray();

        int prevStart = data[0][0];
        int prevEnd = data[0][1];

        for(int i = 1; i < data.Length; i++) {
            int currStart = data[i][0];
            int currEnd = data[i][1];

            if(prevEnd > currStart) {
                return false;
            } else {
                prevStart = currStart;
                prevEnd = currEnd;
            }
        }

        return true;
    }
}
// @lc code=end

