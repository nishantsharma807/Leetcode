/*
 * @lc app=leetcode id=210 lang=csharp
 *
 * [210] Course Schedule II
 */

// @lc code=start
public class Solution {
    public int[] FindOrder(int numCourses, int[][] prerequisites) {
        var adjList = Enumerable.Range(1, numCourses).Select(_ => new List<int>()).ToList();

        foreach(int[] pair in prerequisites) {
            adjList[pair[1]].Add(pair[0]);
        }

        int[] inDegree = new int[numCourses];
        for(int i = 0; i < numCourses; i++) {
            foreach(int n in adjList[i]) {
                inDegree[n]++;
            }
        }

        var queue = new Queue<int>();

        for(int i = 0; i < inDegree.Length; i++) {
            if(inDegree[i] == 0) queue.Enqueue(i);
        }

        var topo = new List<int>();

        while(queue.Count > 0) {
            var curr = queue.Dequeue();
            topo.Add(curr);

            foreach(int adj in adjList[curr]) {
                inDegree[adj]--;
                if(inDegree[adj] == 0) queue.Enqueue(adj);
            }
        }

        return topo.Count == numCourses ? topo.ToArray() : new int[] {};
    }
}
// @lc code=end

