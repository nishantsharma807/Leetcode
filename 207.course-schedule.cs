/*
 * @lc app=leetcode id=207 lang=csharp
 *
 * [207] Course Schedule
 */

// @lc code=start
public class Solution {
    public bool CanFinish(int numCourses, int[][] prerequisites) {
        var adjList = Enumerable.Range(1, numCourses).Select(_ => new List<int>()).ToList();
        
        foreach(int[] pair in prerequisites) {
            adjList[pair[0]].Add(pair[1]);
        }

        var queue = new Queue<int>();
        var inDegree = new int[numCourses];

        for(int i = 0; i < numCourses; i++) {
            foreach(int num in adjList[i]) {
                inDegree[num]++;
            }
        }

        for(int i = 0; i < inDegree.Length; i++) {
            if(inDegree[i] == 0) queue.Enqueue(i);
        }

        var topo = new List<int>();

        while(queue.Count > 0) {
            var curr = queue.Dequeue();
            topo.Add(curr);

            foreach(int neighbor in adjList[curr]) {
                inDegree[neighbor]--;
                if(inDegree[neighbor] == 0) queue.Enqueue(neighbor);
            }
        }

        return topo.Count == numCourses;
    }
}
// @lc code=end

