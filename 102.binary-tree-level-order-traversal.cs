/*
 * @lc app=leetcode id=102 lang=csharp
 *
 * [102] Binary Tree Level Order Traversal
 */

// @lc code=start
/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */
public class Solution {
    public IList<IList<int>> LevelOrder(TreeNode root) {
        var result = new List<IList<int>>();
        if(root == null) return result;

        var queue = new Queue<TreeNode>();
        queue.Enqueue(root);

        while(queue.Count > 0) {
            var record = new List<int>();
            int size = queue.Count;

            for(int i = 0; i < size; i++) {
                var node = queue.Dequeue();

                if(node.left != null) queue.Enqueue(node.left);
                if(node.right != null) queue.Enqueue(node.right);

                record.Add(node.val);
            }

            result.Add(record);
        }

        return result;
    }
}
// @lc code=end

