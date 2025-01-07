/*
 * @lc app=leetcode id=785 lang=csharp
 *
 * [785] Is Graph Bipartite?
 */

// @lc code=start
public class Solution {
    private int[] colorArray;
    public bool IsBipartite(int[][] graph) {
        colorArray = new int[graph.Length];

        for(int i = 0; i < colorArray.Length; i++) colorArray[i] = -1;

        for(int i = 0; i < graph.Length; i++) {
            if(colorArray[i] == -1) {
                if(!DFSTraversal(graph, i, 0)) return false;
            }
        }

        return true;
    }

    private bool DFSTraversal(int[][] graph, int node, int color) {
        colorArray[node] = color;
        int newColor = color == 0 ? 1 : 0;

        foreach(int adj in graph[node]) {
            if(colorArray[adj] == -1) {
                if(!DFSTraversal(graph, adj, newColor)) return false;
            }
            else if(colorArray[adj] == color) return false;
        }

        return true;
    }
}
// @lc code=end

