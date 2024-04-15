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
    private int sum  = 0;

    public int SumNumbers(TreeNode root) {
        DFS(root, 0);
        return sum;
    }

    private void DFS(TreeNode root, int currentNumber){
        if(root == null){
            return;
        }

        currentNumber = currentNumber*10 + root.val;

        if(root.left == null && root.right == null){
            sum += currentNumber;
            return;
        }

        DFS(root.left, currentNumber);
        DFS(root.right, currentNumber);
    }
}