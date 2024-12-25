/*
 * @lc app=leetcode id=794 lang=csharp
 *
 * [794] Valid Tic-Tac-Toe State
 */

// @lc code=start
public class Solution {
    public bool ValidTicTacToe(string[] board) {
        int xCount = 0, oCount = 0;
        bool isXWin = false, isOWin = false;

        for(int i = 0; i < board.Length; i++) {
            isXWin = isXWin || board[i] == "XXX";
            isOWin = isOWin || board[i] == "OOO";

            for(int j = 0; j < board[i].Length; j++) {
                if(board[i][j] == 'X') xCount++;
                else if(board[i][j] == 'O') oCount++;
            }
        }

        if(oCount > xCount || (xCount - oCount) > 1) return false;
        if((isXWin || IsWin("X", board)) && oCount >= xCount) return false;
        if((isOWin || IsWin("O", board)) && xCount > oCount) return false;

        return true;
    }

    private bool IsWin(string c, string[] board) {
        string target = c + c + c;
        string leftDiagonal = "", rightDiagonal = "";
        //Column check
        for(int i = 0; i < board.Length; i++) {
            string curr = "";
            for(int j = 0; j < board[i].Length; j++) {
                curr += board[j][i];

                if(i == j) leftDiagonal += board[i][j];
                if(i + j == board.Length - 1) rightDiagonal += board[i][j];

                if(leftDiagonal == target || rightDiagonal == target) return true;
            }
            if(curr == target) return true;
        }

        return false;
    }
}
// @lc code=end

