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
    
    public TreeNode SortedArrayToBST(int[] num) {
		if (num.Length == 0)
			return null;
 
		return SortedArrayToBST(num, 0, num.Length - 1);
	}
 
	public TreeNode SortedArrayToBST(int[] num, int start, int end) {
		if (start > end)
			return null;
 
		var mid = (start + end) / 2;
		var root = new TreeNode(num[mid]);
		root.left = SortedArrayToBST(num, start, mid - 1);
		root.right = SortedArrayToBST(num, mid + 1, end);
 
		return root;
	}
}