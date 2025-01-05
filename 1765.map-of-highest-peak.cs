/*
 * @lc app=leetcode id=1765 lang=csharp
 *
 * [1765] Map of Highest Peak
 */

// @lc code=start
public class Solution {
    private List<(int row, int col)> _directions = new List<(int row, int col)>() 
    {
        (0, -1), (0, 1), (-1, 0), (1, 0)
    };

    public int[][] HighestPeak(int[][] isWater) {
        var queue = new Queue<(int row, int col, int distance)>();
        int[][] visited = Enumerable.Range(1, isWater.Length).Select(_ => new int[isWater[0].Length]).ToArray();
        int[][] result = Enumerable.Range(1, isWater.Length).Select(_ => new int[isWater[0].Length]).ToArray();

        for(int i = 0; i < isWater.Length; i++) {
            for(int j = 0; j < isWater[i].Length; j++) {
                if(isWater[i][j] == 1) {
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

                if(IsValidIndex(nextRow, nextCol, isWater) && visited[nextRow][nextCol] == 0) {
                    visited[nextRow][nextCol] = 1;
                    queue.Enqueue((nextRow, nextCol, distance + 1));
                }
            }
        }

        return result;
    }

    private bool IsValidIndex(int row, int col, int[][] isWater) {
        return row >= 0 && col >= 0 && row < isWater.Length && col < isWater[0].Length;
    }
}
// @lc code=end

