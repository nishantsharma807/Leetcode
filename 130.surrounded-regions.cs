/*
 * @lc app=leetcode id=130 lang=csharp
 *
 * [130] Surrounded Regions
 */

// @lc code=start
public class Solution {    
    private List<(int row, int col)> _directions = new List<(int row, int col)>() 
    {
        (0, -1), (0, 1), (-1, 0), (1, 0)
    };

    public void Solve(char[][] board) {
        int[][] visited = Enumerable.Range(1, board.Length).Select(_ => new int[board[0].Length]).ToArray();

        int[] edgeRows = new int[] { 0, board.Length - 1 };
        int[] edgeCols = new int[] { 0, board[0].Length - 1 };

        //Traverse Top and Bottom boundaries
        foreach(int row in edgeRows) {
            for(int col = 0; col < board[0].Length; col++) {
                if(board[row][col] == 'O' && visited[row][col] == 0) {
                    DFSTraverse(row, col, board, visited);
                }
            }
        }

        //Traverse Left and Right boundaries
        foreach(int col in edgeCols) {
            for(int row = 0; row < board.Length; row++) {
                if(board[row][col] == 'O' && visited[row][col] == 0) {
                    DFSTraverse(row, col, board, visited);
                }
            }
        }

        for(int i = 0; i < board.Length; i++) {
            for(int j = 0; j < board[i].Length; j++) {
                if(board[i][j] == 'O' && visited[i][j] == 0) {
                    board[i][j] = 'X';
                }
            }
        }
    }

    private void DFSTraverse(int row, int col, char[][] board, int[][] visited) {
        visited[row][col] = 1;
        
        foreach(var dir in _directions) {
            int newRow = row + dir.row;
            int newCol = col + dir.col;

            if(IsValidIndex(newRow, newCol, board)
            && visited[newRow][newCol] == 0
            && board[newRow][newCol] == 'O') 
            {
                DFSTraverse(newRow, newCol, board, visited);
            }
        }
    }

    private bool IsValidIndex(int row, int col, char[][] mat) {
        return row >= 0 && col >= 0 && row < mat.Length && col < mat[0].Length;
    }
}
// @lc code=end

