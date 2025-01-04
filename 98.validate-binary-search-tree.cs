/*
 * @lc app=leetcode id=98 lang=csharp
 *
 * [98] Validate Binary Search Tree
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
    private int? prevVal = null;

    public bool IsValidBST(TreeNode root) {
        return InorderTraverse(root);
    }

    public bool InorderTraverse(TreeNode node) {
        if(node == null) return true;

        bool left = InorderTraverse(node.left);

        if(prevVal != null && prevVal >= node.val) return false;
        prevVal = node.val;

        bool right = InorderTraverse(node.right);

        return left && right;
    }
}
// @lc code=end

