/*
 * @lc app=leetcode id=653 lang=csharp
 *
 * [653] Two Sum IV - Input is a BST
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
        var result = new List<int>();
        Traverse(root, result);

        int left = 0, right = result.Count - 1;

        while(left < right) {
            int sum = result[left] + result[right];

            if(sum == k) return true;
            else if(sum > k) right--;
            else left++;
        }

        return false;
    }

    public void Traverse(TreeNode node, List<int> result) {
        if(node == null) return;

        Traverse(node.left, result);
        result.Add(node.val);
        Traverse(node.right, result);
    }
}
// @lc code=end

