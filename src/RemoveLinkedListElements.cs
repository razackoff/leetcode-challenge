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
    public ListNode RemoveElements(ListNode head, int val) {
        List<int> list = new List<int>();

        while(head != null)
        {
            if(head.val != val)
            {
                list.Add(head.val);
            }
            head = head.next;
        }

        if(list.Count() == 0)
        {
            return null;
        }

        ListNode result = new ListNode();
        ListNode dumm = result;
        for(int i = 0; i < list.Count(); i++)
        {
            dumm.val = list[i];
            if(i != list.Count() - 1)
            {
                dumm.next = new ListNode();
                dumm = dumm.next;
            }
            
        }
        return result;
    }
}