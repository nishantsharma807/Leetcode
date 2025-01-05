/*
 * @lc app=leetcode id=200 lang=csharp
 *
 * [200] Number of Islands
 */

// @lc code=start
public class Solution {
    private int[][] visited;
    public int NumIslands(char[][] grid) {
        int result = 0;
        visited = Enumerable.Range(1, grid.Length).Select(_ => new int[grid[0].Length]).ToArray();

        for(int i = 0; i < grid.Length; i++) {
            for(int j = 0; j < grid[i].Length; j++) {
                if(grid[i][j] == '1' && visited[i][j] == 0) {
                    result++;
                    DfsTraversal(grid, i, j);
                }
            }
        }

        return result;
    }

    private void DfsTraversal(char[][] grid, int i, int j) {
        visited[i][j] = 1;

        //Left
        if(j - 1 >= 0 && visited[i][j - 1] == 0 && grid[i][j - 1] == '1') DfsTraversal(grid, i , j - 1);

        //Right
        if(j + 1 < grid[i].Length && visited[i][j + 1] == 0 && grid[i][j + 1] == '1') DfsTraversal(grid, i , j + 1);

        //Top
        if(i - 1 >= 0 && visited[i - 1][j] == 0 && grid[i - 1][j] == '1') DfsTraversal(grid, i - 1, j);

        //Bottom
        if(i + 1 < grid.Length && visited[i + 1][j] == 0 && grid[i + 1][j] == '1') DfsTraversal(grid, i + 1, j);
    }
}
// @lc code=end

