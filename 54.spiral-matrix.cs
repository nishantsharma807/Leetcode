/*
 * @lc app=leetcode id=54 lang=csharp
 *
 * [54] Spiral Matrix
 */

// @lc code=start
public class Solution {
    public IList<int> SpiralOrder(int[][] matrix) {
        var result = new List<int>();
        int totalElements = matrix.Length * matrix[0].Length;
        int left = 0, right = matrix[0].Length - 1;
        int top = 0, bottom = matrix.Length -1;

        while(result.Count < totalElements) {
            for(int i = left; i <= right; i++) {
                if(result.Count < totalElements) result.Add(matrix[top][i]);
            }
            top++;

            for(int i = top; i <= bottom; i++) {
                if(result.Count < totalElements) result.Add(matrix[i][right]);
            }
            right--;

            for(int i = right; i >= left; i--) {
                if(result.Count < totalElements) result.Add(matrix[bottom][i]);
            }
            bottom--;

            for(int i = bottom; i >= top; i--) {
                if(result.Count < totalElements) result.Add(matrix[i][left]);
            }
            left++;
        }

        return result;
    }
}
// @lc code=end

