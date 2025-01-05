/*
 * @lc app=leetcode id=542 lang=csharp
 *
 * [542] 01 Matrix
 */

// @lc code=start
public class Solution {
    private List<(int row, int col)> _directions = new List<(int row, int col)>() 
    {
        (0, -1), (0, 1), (-1, 0), (1, 0)
    };

    public int[][] UpdateMatrix(int[][] mat) {
        var queue = new Queue<(int row, int col, int distance)>();
        int[][] visited = Enumerable.Range(1, mat.Length).Select(_ => new int[mat[0].Length]).ToArray();
        int[][] result = Enumerable.Range(1, mat.Length).Select(_ => new int[mat[0].Length]).ToArray();

        for(int i = 0; i < mat.Length; i++) {
            for(int j = 0; j < mat[i].Length; j++) {
                if(mat[i][j] == 0) {
                    visited[i][j] = 1;
                    queue.Enqueue((i, j, 0));
                }                
            }
        }

        while(queue.Count > 0) {
            var (row, col, distance) = queue.Dequeue();
            result[row][col] = distance;

            foreach(var dir in _directions) {
                int nextRow = row + dir.row;
                int nextCol = col + dir.col;

                if(IsValidIndex(nextRow, nextCol, mat) && visited[nextRow][nextCol] == 0) {
                    visited[nextRow][nextCol] = 1;
                    queue.Enqueue((nextRow, nextCol, distance + 1));
                }
            }
        }

        return result;        
    }

    private bool IsValidIndex(int row, int col, int[][] mat) {
        return row >= 0 && col >= 0 && row < mat.Length && col < mat[0].Length;
    }
}
// @lc code=end

