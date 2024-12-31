/*
 * @lc app=leetcode id=144 lang=csharp
 *
 * [144] Binary Tree Preorder Traversal
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
    public IList<int> PreorderTraversal(TreeNode root) {
        //Preorder -> Root, left, right
        var result = new List<int>();
        if(root == null) return result;

        // Begin iterative
        var stack = new Stack<TreeNode>();
        stack.Push(root);

        while(stack.Count > 0) {
            var node = stack.Pop();
            result.Add(node.val);
            
            // Because stack is LIFO do right first;
            if(node.right != null) stack.Push(node.right);
            if(node.left != null) stack.Push(node.left);
        }

        // End iterative

        // Recursive
        // Traversal(root, result); 
        return result;
    }

    //Recursive
    public void Traversal(TreeNode node, List<int> result) {
        if(node == null) return;
        result.Add(node.val);
        Traversal(node.left, result);
        Traversal(node.right, result);
    }
}
// @lc code=end

