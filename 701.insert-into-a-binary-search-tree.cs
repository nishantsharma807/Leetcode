/*
 * @lc app=leetcode id=701 lang=csharp
 *
 * [701] Insert into a Binary Search Tree
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
    public TreeNode InsertIntoBST(TreeNode root, int val) {
        if(root == null) return new TreeNode(val);
        var node = root;

        while(node != null) {
            if(val > node.val) {
                if(node.right != null) node = node.right;
                else {
                    node.right = new TreeNode(val);
                    break;
                }
            } else {
                if(node.left != null) node = node.left;
                else  {
                    node.left = new TreeNode(val);
                    break;
                }
            }
        }

        return root;
    }
}
// @lc code=end

