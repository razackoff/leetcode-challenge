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
    public ListNode Partition(ListNode head, int x) {
        ListNode left = new ListNode();
            ListNode right = new ListNode();
            ListNode rightPrev = right;
            ListNode leftPrev = left;
            ListNode curr = head;

            while (curr != null)
            {
                if(curr.val < x)
                {
                    left.next = curr;
                    left = left.next;
                }
                else
                {
                    right.next = curr;
                    right = right.next;
                }
                curr = curr.next;
            }
            right.next = null;
            left.next = rightPrev.next;

            return leftPrev.next;
    }
}