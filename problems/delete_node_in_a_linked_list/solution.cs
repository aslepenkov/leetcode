/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
public class Solution {
    public void DeleteNode(ListNode node) {
        Console.WriteLine("node "+ node.val + ". next " + node.next.val);
        
        var next = node.next;
        node.val = next.val;
        node.next = next.next;
       
    }
}