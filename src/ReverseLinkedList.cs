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
    public ListNode ReverseList(ListNode head) {
        ListNode cur = head;
        ListNode prev = null;
        ListNode nxt = null;
        while (cur != null)
        {
            nxt = cur.next;
            cur.next = prev;
            prev = cur;
            cur = nxt;
        }

        return prev;
    }
}