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
    public bool IsValidBST(TreeNode root) {
        
        if(root == null) return true;
         
        if(root.right == null && root.left == null){
            return true;
        }

        return isValid(root, double.MaxValue, double.NegativeInfinity);
    }
    
    public bool isValid(TreeNode root, double max, double min){
        
        if(root == null)
            return true;
        
        if(root.val <= min || root.val >= max){
            return false;
        }
        
        return isValid(root.left, root.val, min) && isValid(root.right, max, root.val);
        
    }
}