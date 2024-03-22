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
        var stringBuilder = new StringBuilder();
        while (head != null)
        {
            stringBuilder.Append(head.val);
            head = head.next;
        }
        var number = stringBuilder.ToString();
        return number.SequenceEqual(number.Reverse());
    }
}