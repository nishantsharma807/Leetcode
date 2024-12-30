/*
 * @lc app=leetcode id=74 lang=csharp
 *
 * [74] Search a 2D Matrix
 */

// @lc code=start
public class Solution {
    public bool SearchMatrix(int[][] matrix, int target) {
        int left = 0, right = (matrix.Length * matrix[0].Length) - 1;

        while(left <= right) {
            int mid = (left + right) / 2;
            int row = mid / matrix[0].Length;
            int col = mid % matrix[0].Length;

            if(matrix[row][col] == target) return true;
            else if(target > matrix[row][col]) left = mid + 1;
            else right = mid - 1;
        }

        return false;

        // for(int i = 0; i < matrix.Length; i++) {
        //     int right = matrix[i].Length - 1;
        //     if(target > matrix[i][right]) continue;
        //     int left = 0;

        //     while(left <= right) {
        //         int mid = (left + right) / 2;
        //         if(matrix[i][mid] == target) return true;
        //         else if(target > matrix[i][mid]) left = mid + 1;
        //         else right = mid - 1;
        //     }
        // }

        // return false;
    }
}
// @lc code=end

