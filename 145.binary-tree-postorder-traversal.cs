/*
 * @lc app=leetcode id=145 lang=csharp
 *
 * [145] Binary Tree Postorder Traversal
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
    public IList<int> PostorderTraversal(TreeNode root) {
        //PostOrder -> Left, Right, Root
        var result = new List<int>();
        Traversal(root, result);
        return result;
    }

    public void Traversal(TreeNode node, List<int> result) {
        if(node == null) return;
        Traversal(node.left, result);
        Traversal(node.right, result);
        result.Add(node.val);
    }
}
// @lc code=end

