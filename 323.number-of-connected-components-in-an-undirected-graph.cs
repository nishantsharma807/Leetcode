/*
 * @lc app=leetcode id=323 lang=csharp
 *
 * [323] Number of Connected Components in an Undirected Graph
 */

// @lc code=start
public class Solution {
    private int result = 0;
    private List<List<int>> adjList;
    private int[] visited;

    public int CountComponents(int n, int[][] edges) {
        visited = new int[n];        
        adjList = BuildAdjList(edges, n);

        //BFS Traversal
        //BfsTraversal(visited);

        //DFS Traversal
        for(int i = 0; i < visited.Length; i++) {
            if(visited[i] == 1) continue;
            result++;
            DfsTraversal(i);
        }

        return result;
    }

    public void BfsTraversal(int[] visited) {
        var queue = new Queue<int>();

        for(int i = 0; i < visited.Length; i++) {
            if(visited[i] == 1) continue;
            queue.Enqueue(i);
            visited[i] = 1;
            result++;

            while(queue.Count > 0) 
            {
                var curr = queue.Dequeue();
                foreach(int node in adjList[curr]) 
                {
                    if(visited[node] != 1)  {
                        queue.Enqueue(node);
                        visited[node] = 1;
                    }
                }
            }
        }
    }

    private void DfsTraversal(int node) {
        visited[node] = 1;
        foreach(int n in adjList[node]) {
            if(visited[n] != 1) {
                DfsTraversal(n);
            }
        }
    }

    private List<List<int>> BuildAdjList(int[][] edges, int n) {
        var list = Enumerable.Range(0, n).Select(_ => new List<int>()).ToList();

        for(int i = 0; i < edges.Length; i++) {
            int node1 = edges[i][0];
            int node2 = edges[i][1];

            list[node1].Add(node2);
            list[node2].Add(node1);
        }

        return list;
    }
}
// @lc code=end

