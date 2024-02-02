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
        ListNode slow = head, fast = head, prev = null;
        int count = 0;
        for(int i = 0; i < n; i++) {
            fast = fast.next;
        }       

        while(fast != null) {
            prev = slow;
            slow = slow.next;
            fast = fast.next;
        }

        if(prev == null) {
            return slow.next;
        } else {
            prev.next = slow.next;
            return head;
        }
    }
}