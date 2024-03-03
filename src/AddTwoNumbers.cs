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
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2) {
        ListNode head = new ListNode(0, null);
        var current = head;
        int balance = 0;
        while(l1 is not null || l2 is not null || balance is not 0){
            current.next = new ListNode();
            current = current.next;
            if(l1 != null && l2 != null){
                balance = balance + l1.val + l2.val;
                l1 = l1.next;
                l2 = l2.next;
            }
            else if(l1 is not null && l2 is null){
                balance = balance + l1.val;
                l1 = l1.next;
            }
            else if(l2 is not null && l1 is null){
                balance = balance + l2.val;
                l2 = l2.next;
            }
            current.val = balance % 10;
            balance = balance / 10;
        }
        return head.next;
    }
}