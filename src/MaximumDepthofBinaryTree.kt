/**
 * Example:
 * var ti = TreeNode(5)
 * var v = ti.`val`
 * Definition for a binary tree node.
 * class TreeNode(var `val`: Int) {
 *     var left: TreeNode? = null
 *     var right: TreeNode? = null
 * }
 */
class Solution {
    fun maxDepth(root: TreeNode?): Int {
        if(root?.`val` == null){
            return 0
        }
        var left : Int = maxDepth(root.left)
        var right : Int = maxDepth(root.right)

        if(left >= right){
            return left + 1
        }
        else{
            return right + 1
        }
    }
}