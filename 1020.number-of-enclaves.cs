/*
 * @lc app=leetcode id=1020 lang=csharp
 *
 * [1020] Number of Enclaves
 */

// @lc code=start
public class Solution {
    private List<(int row, int col)> _directions = new List<(int row, int col)>() {
        (0, -1), (0, 1), (-1, 0), (1, 0)
    };
    private int[][] visited;
    private Queue<(int row, int col)> queue = new Queue<(int row, int col)>();

    public int NumEnclaves(int[][] grid) {
        int result = 0;
        visited = Enumerable.Range(1, grid.Length).Select(_ => new int[grid[0].Length]).ToArray();

        int[] edgeRows = new int[] { 0, grid.Length - 1 };
        int[] edgeCols = new int[] { 0, grid[0].Length - 1 };

        //Traverse Top and Bottom boundaries
        foreach(int row in edgeRows) {
            for(int col = 0; col < grid[0].Length; col++) {
                if(grid[row][col] == 1 && visited[row][col] == 0) {
                    //BFS
                    visited[row][col] = 1;
                    queue.Enqueue((row, col));
                    //DFSTraversal(row, col, grid);
                }
            }
        }

        //Traverse Left and Right boundaries
        foreach(int col in edgeCols) {
            for(int row = 0; row < grid.Length; row++) {
                if(grid[row][col] == 1 && visited[row][col] == 0) {
                    //BFS
                    visited[row][col] = 1;
                    queue.Enqueue((row, col));
                    // DFSTraversal(row, col, grid);
                }
            }
        }

        BFSTraversal(grid);

        for(int i = 0; i < grid.Length; i++) {
            for(int j = 0; j < grid[i].Length; j++) {
                if(grid[i][j] == 1 && visited[i][j] == 0) result++;
            }
        }

        return result;
    }

    private void BFSTraversal(int[][] grid) {
        while(queue.Count > 0) {
            var (row, col) = queue.Dequeue();

            foreach(var dir in _directions) {
                int newRow = row + dir.row;
                int newCol = col + dir.col;

                if(IsValidIndex(newRow, newCol, grid) && grid[newRow][newCol] == 1 
                && visited[newRow][newCol] == 0) {
                    visited[newRow][newCol] = 1;
                    queue.Enqueue((newRow, newCol));
                }
            }
        }
    }

    private void DFSTraversal(int row, int col, int[][] grid) {
        visited[row][col] = 1;

        foreach(var dir in _directions) {
            int newRow = row + dir.row;
            int newCol = col + dir.col;

            if(IsValidIndex(newRow, newCol, grid) && grid[newRow][newCol] == 1 
            && visited[newRow][newCol] == 0) {
                DFSTraversal(newRow, newCol, grid);
            }
        }
    }

    private bool IsValidIndex(int row, int col, int[][] grid) {
        return row >= 0 && col >= 0 && row < grid.Length && col < grid[0].Length;
    }
}
// @lc code=end

