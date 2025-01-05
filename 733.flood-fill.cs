/*
 * @lc app=leetcode id=733 lang=csharp
 *
 * [733] Flood Fill
 */

// @lc code=start
public class Solution {
    private Queue<(int row, int col)> queue = new Queue<(int row, int col)>();
    private int startingColor = 0;
    
    public int[][] FloodFill(int[][] image, int sr, int sc, int color) {  
        
        startingColor = image[sr][sc];

        //DFS
        if(startingColor != color) {
            DFSTraversal(image, color, sr, sc);
        }

        return image;

        //BFS started
        // if(startingColor != color) {
        //     queue.Enqueue((sr, sc));
        //     image[sr][sc] = color;
        // }

        // return BFSTraversal(image, color);
        //BFS ended
    }

    public void DFSTraversal(int[][] image, int color, int row, int col) {
        image[row][col] = color;

        if(col - 1 >= 0 && image[row][col - 1] == startingColor) {
            DFSTraversal(image, color, row, col - 1);
        }

        //Right
        if(col + 1 < image[row].Length && image[row][col + 1] == startingColor) {
            DFSTraversal(image, color, row, col + 1);
        }

        //Top
        if(row - 1 >= 0 && image[row - 1][col] == startingColor) {
            DFSTraversal(image, color, row - 1, col);
        }

        //Bottom
        if(row + 1 < image.Length && image[row + 1][col] == startingColor) {
            DFSTraversal(image, color, row + 1, col);
        }
    }

    private int[][] BFSTraversal(int[][] image, int color) {
        while(queue.Count > 0) {
            var curr = queue.Dequeue();
            int row = curr.row, col = curr.col;

            //Left
            if(col - 1 >= 0 && image[row][col - 1] == startingColor) {
                image[row][col - 1] = color;
                queue.Enqueue((row, col - 1));
            }

            //Right
            if(col + 1 < image[row].Length && image[row][col + 1] == startingColor) {
                image[row][col + 1] = color;
                queue.Enqueue((row, col + 1));
            }

            //Top
            if(row - 1 >= 0 && image[row - 1][col] == startingColor) {
                image[row - 1][col] = color;
                queue.Enqueue((row - 1, col));
            }

            //Bottom
            if(row + 1 < image.Length && image[row + 1][col] == startingColor) {
                image[row + 1][col] = color;
                queue.Enqueue((row + 1, col));
            }
        }

        return image;
    }
}
// @lc code=end

