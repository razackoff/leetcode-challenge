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
    public ListNode MiddleNode(ListNode head) {
            ListNode oriHead = head;
            int counter = 0;

            while (head.next is not null)
            {
                counter++;
                head = head.next;
            }

            for (int i = 0; i < Math.Ceiling(1.0D * counter / 2); i++)
                oriHead = oriHead.next;

            return oriHead;
    }
}