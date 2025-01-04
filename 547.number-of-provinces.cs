/*
 * @lc app=leetcode id=547 lang=csharp
 *
 * [547] Number of Provinces
 */

// @lc code=start
public class Solution {
        private int result = 0;
    public int FindCircleNum(int[][] isConnected) {
        var visited = new int[isConnected.Length];

        for(int i = 0; i < visited.Length; i++) {
            if(visited[i] != 1) {
                result++;
                DfsTraversal(isConnected, i, visited);
            }
        }

        return result;
    }

    public void DfsTraversal(int[][] isConnected, int node, int[] visited) {
        visited[node] = 1;

        for(int i = 0; i < isConnected[node].Length; i++) {
            if(i != node && isConnected[node][i] == 1 && visited[i] != 1) {
                DfsTraversal(isConnected, i, visited);
            }
        } 
    }
}
// @lc code=end

