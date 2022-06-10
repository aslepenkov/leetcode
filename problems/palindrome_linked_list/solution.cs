/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */
public class Solution {
    public bool IsPalindrome(ListNode head) {
        
        var isPalindrome = true;
 
        //fill array
        var list = new List<int>();
        var node = head;
        
        while (node != null) {
          list.Add(node.val);
          node = node.next;
        }
        
        //check array 
        var arr = list.ToArray();
        if (arr.Length == 1)
            return true;
        
        var n = arr.Length;
       
        for (int i = 0; i <= n / 2 && n != 0; i++)
        {
            if (arr[i] != arr[n - i - 1])
            {
                isPalindrome = false;
                break;
            }
        }
        
        return isPalindrome;
    }
}