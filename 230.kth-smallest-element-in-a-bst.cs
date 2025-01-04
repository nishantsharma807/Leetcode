/*
 * @lc app=leetcode id=230 lang=csharp
 *
 * [230] Kth Smallest Element in a BST
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
    private int counter = 0;
    private int result = 0;

    public int KthSmallest(TreeNode root, int k) {
        Traversal(root, k);
        return result;
    }

    public void Traversal(TreeNode node, int k) {
        if(node == null) return;

        Traversal(node.left, k);

        counter++;
        if(counter == k) {
            result = node.val;
            return;
        }

        Traversal(node.right, k);
    }
}
// @lc code=end

