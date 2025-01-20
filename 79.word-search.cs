/*
 * @lc app=leetcode id=79 lang=csharp
 *
 * [79] Word Search
 */

// @lc code=start
public class Solution {
    private List<(int row, int col)> _directions = new List<(int row, int col)>() 
    {
        (0, -1), (0, 1), (-1, 0), (1, 0)
    };

    public bool Exist(char[][] board, string word) {
        var visited = Enumerable.Range(1, board.Length).Select(_ => new int[board[0].Length]).ToArray();

        for(int i = 0; i < board.Length; i++) {
            for(int j = 0; j < board[i].Length; j++) {
                if(word[0] == board[i][j] && DFSTraversal(i, j, word, 0, board, visited)) {
                    return true;
                }
            }
        }

        return false;
    }

    private bool DFSTraversal(int row, int col, string word, int currLength, char[][] board, int[][] visited) {
        if(currLength == word.Length) return true;

        if(!IsValidIndex(row, col, board) || visited[row][col] == 1 || word[currLength] != board[row][col]) return false;

        visited[row][col] = 1;

        foreach(var dir in _directions) {
            int newRow = row + dir.row;
            int newCol = col + dir.col;
            
            if(DFSTraversal(newRow, newCol, word, currLength + 1, board, visited)) return true;                
        }

        visited[row][col] = 0;

        return false;
    }

    private bool IsValidIndex(int row, int col, char[][] board) {
        return row >= 0 && col >= 0 && row < board.Length && col < board[0].Length;
    }
}
// @lc code=end

