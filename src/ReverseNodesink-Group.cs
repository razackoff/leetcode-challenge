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
    public ListNode ReverseKGroup(ListNode head, int k) {
        if(head.next == null || k == 1){
            return head;
        }
        ListNode curr = head;
        ListNode ansEnd = new ListNode(curr.val);
        ListNode ansHead = ansEnd;
        ListNode local = ansEnd;
        ListNode reverseLast = ansEnd;
        ListNode reverseHead = ansEnd;
        int kk = 1, flag = 0, d = 1;
        curr = curr.next;
        while(curr != null){
            if(kk == k){
                if(flag == 0){
                    ansHead = reverseHead;
                    ansEnd = reverseLast;
                }
                else{
                    ansEnd.next = reverseHead;
                    ansEnd = reverseLast;
                }
                flag = 1;
                kk = 0;
            }
            if(kk == 0){
                reverseHead = new ListNode(curr.val);
                reverseLast = reverseHead;
                kk++;
            }
            else if(kk < k){
                local = new ListNode(curr.val);
                local.next = reverseHead;
                reverseHead = local;
                kk++;
            }
                
            d++;
                /*if(d == 2){
                    return reverseHead;
                }*/
            curr = curr.next;
                
        }
        if(flag == 0 && kk == k){
            return reverseHead;
        }
        if(kk == k){
            ansEnd.next = reverseHead;
        }
        if(kk < k && reverseHead != null && kk != 0){
            ListNode remainHead = new ListNode(reverseHead.val);
            reverseHead = reverseHead.next;
            while(reverseHead != null){
                local = null;
                local = new ListNode(reverseHead.val);
                local.next = remainHead;
                remainHead = local;
                reverseHead = reverseHead.next;
            }
            ansEnd.next = remainHead;
        }
        return ansHead;
    }
}