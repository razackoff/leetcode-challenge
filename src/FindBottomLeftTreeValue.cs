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
    public int FindBottomLeftValue(TreeNode root) {
        int depth = 0;
        int leftmostValue = 0;
        FindBottomLeftValueHelper(root, 1, ref depth, ref leftmostValue);
        return leftmostValue;
    }

    private void FindBottomLeftValueHelper(TreeNode node, int currentDepth, ref int maxDepth, ref int leftmostValue) {
        if (node == null) return;
        
        if (currentDepth > maxDepth) {
            maxDepth = currentDepth;
            leftmostValue = node.val;
        }
        
        FindBottomLeftValueHelper(node.left, currentDepth + 1, ref maxDepth, ref leftmostValue);
        FindBottomLeftValueHelper(node.right, currentDepth + 1, ref maxDepth, ref leftmostValue);
    }
}