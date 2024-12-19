/*
 * @lc app=leetcode id=36 lang=csharp
 *
 * [36] Valid Sudoku
 */

// @lc code=start
public class Solution {
    public bool IsValidSudoku(char[][] board) {
        var listSet = new List<HashSet<char>>();

        for(int i = 0; i < board.Length; i++) {
            var rowSet = new HashSet<char>();
            var colSet = new HashSet<char>();

            for(int j = 0; j < board[i].Length; j++) {
                if(board[i][j] != '.') {
                    if(rowSet.Contains(board[i][j])) return false;
                    rowSet.Add(board[i][j]);
                }

                if(board[j][i] != '.') {
                    if(colSet.Contains(board[j][i])) return false;
                    colSet.Add(board[j][i]);
                }

                //Box check
                var index = (i / 3) * 3 + j / 3;
                if(listSet.ElementAtOrDefault(index) == null) {
                    listSet.Insert(index, new HashSet<char>());
                }

                if(board[i][j] != '.') {
                    if(listSet[index].Contains(board[i][j])) return false; 
                    listSet[index].Add(board[i][j]);
                }
                
            }
        }

        return true;
    }
}
// @lc code=end

