/*
 * @lc app=leetcode id=100 lang=csharp
 *
 * [100] Same Tree
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
    public bool IsSameTree(TreeNode p, TreeNode q) {
        if(p == null || q == null) return p == q;

        return p.val == q.val && IsSameTree(p.left, q.left) && IsSameTree(p.right, q.right);
    }
}
// @lc code=end

