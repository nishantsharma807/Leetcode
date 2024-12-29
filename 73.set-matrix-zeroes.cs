/*
 * @lc app=leetcode id=73 lang=csharp
 *
 * [73] Set Matrix Zeroes
 */

// @lc code=start
public class Solution {
    public void SetZeroes(int[][] matrix) {
        var setRows = new HashSet<int>();
        var setCols = new HashSet<int>();

        for(int i = 0; i < matrix.Length; i++) {
            for(int j = 0; j < matrix[i].Length; j++) {
                if(matrix[i][j] == 0) {
                    setRows.Add(i);
                    setCols.Add(j);
                }
            }
        }

        foreach(int row in setRows) SetZerosRows(matrix, row);
        foreach(int col in setCols) SetZerosCol(matrix, col);
    }

    private void SetZerosRows(int[][] matrix, int row) {
        for(int i = 0; i < matrix[row].Length; i++) {
            matrix[row][i] = 0;
        }
    }

    private void SetZerosCol(int[][] matrix, int col) {
        for(int i = 0; i < matrix.Length; i++) {
            matrix[i][col] = 0;
        }
    }
}
// @lc code=end

