/*
 * @lc app=leetcode id=48 lang=csharp
 *
 * [48] Rotate Image
 */

// @lc code=start
public class Solution {
    public void Rotate(int[][] matrix) {
        for(int i = 0; i < matrix.Length - 1; i++)
        {
            for(int j = i + 1; j < matrix.Length; j++)
            {
                int temp = matrix[i][j];
                matrix[i][j] = matrix[j][i];
                matrix[j][i] = temp;
            }
        }

        for(int i = 0; i < matrix.Length; i++)
        {
            for(int j = 0; j < matrix.Length/2; j++)
            {
                int temp = matrix[i][j];
                matrix[i][j] = matrix[i][matrix.Length - j -1];
                matrix[i][matrix.Length - j -1] = temp;
            }
        }
    }
}
// @lc code=end

