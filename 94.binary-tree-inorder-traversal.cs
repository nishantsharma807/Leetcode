/*
 * @lc app=leetcode id=94 lang=csharp
 *
 * [94] Binary Tree Inorder Traversal
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
    public IList<int> InorderTraversal(TreeNode root) {
        //Inorder -> Left, Root, Right
        var result = new List<int>();
        if(root == null) return result;

        var stack = new Stack<TreeNode>();
        var node = root;

        while(node != null || stack.Count > 0) {            
            if(node != null) {
                stack.Push(node);
                node = node.left;
            }
            else {
                node = stack.Pop();
                result.Add(node.val);
                node = node.right;
            }
        }

        // Recursive
        // Traversal(root, result);

        return result;
    }

    // Recursive
    public void Traversal(TreeNode node, List<int> result) {
        if(node == null) return;

        Traversal(node.left, result);
        result.Add(node.val);
        Traversal(node.right, result);
    }
}
// @lc code=end

