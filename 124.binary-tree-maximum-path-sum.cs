/*
 * @lc app=leetcode id=124 lang=csharp
 *
 * [124] Binary Tree Maximum Path Sum
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
    private int result = Int32.MinValue;

    public int MaxPathSum(TreeNode root) {
        CalculateMaxPath(root);
        return result;
    }

    public int CalculateMaxPath(TreeNode node) {
        if(node == null) return 0;

        int lh = Math.Max(0, CalculateMaxPath(node.left));
        int rh = Math.Max(0, CalculateMaxPath(node.right));

        result = Math.Max(result, node.val + lh + rh);

        return node.val + Math.Max(lh, rh);
    }
}
// @lc code=end

