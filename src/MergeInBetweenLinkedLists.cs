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
    public ListNode MergeInBetween(ListNode list1, int a, int b, ListNode list2) {
        var head = list1;
        int k = 0;
        ListNode fhead = new(), lhead = new();
        while(head.next != null){
            if(k == a - 1){
                fhead = head;
            }
            if(k == b){
                lhead = head;
            }
            head = head.next;
            k++;
        }
        fhead.next = list2;
        while(list2.next != null){
            list2 = list2.next;
        }
        list2.next = lhead.next;
        return list1;
    }
}