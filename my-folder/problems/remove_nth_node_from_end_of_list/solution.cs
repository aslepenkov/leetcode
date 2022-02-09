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
    public ListNode RemoveNthFromEnd(ListNode head, int n) {
     
        int len = 0;
        var tmp = head;
        while (tmp != null)
        {
            len++;
            tmp = tmp.next;
        }
        
        
        var diff = len - n;        
        var prev = head;    
        var curr = head;  
        if (n == len)
            return head.next;
        
        for(int i = 0; i < diff; i++)
        {
            prev = curr;        
            curr = curr.next;    
        }
        prev.next = curr.next;
        return head;
    }
}