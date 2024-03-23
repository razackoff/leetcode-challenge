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
    public void ReorderList(ListNode head) {
        List<ListNode> li=new List<ListNode>();
        ListNode current=head;
        while(current!=null)
        {
            li.Add(current);
            current=current.next;
        }
        int i=1,j=li.Count-1;
        bool flip=true;
        while(i<=j)
        {
            if(flip)
            {
                head.next=li[j--];
                head= head.next;
            }
            else
            {
                head.next=li[i++];
                head= head.next;
            }
           flip=!flip;
           
        }
         head.next=null;

    }
}