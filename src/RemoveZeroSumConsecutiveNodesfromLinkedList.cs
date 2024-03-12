public class Solution {
    public ListNode RemoveZeroSumSublists(ListNode head) {
        // Create a dummy node to handle cases where the head itself might be part of the zero sum sublist
        ListNode dummy = new ListNode(0);
        dummy.next = head;
        
        Dictionary<int, ListNode> map = new Dictionary<int, ListNode>();
        
        int prefixSum = 0;
        ListNode current = dummy;
        
        while (current != null) {
            prefixSum += current.val;
            
            if (map.ContainsKey(prefixSum)) {
                current = map[prefixSum].next;
                int p = prefixSum + current.val;
                while (p != prefixSum) {
                    map.Remove(p);
                    current = current.next;
                    p += current.val;
                }
                map[prefixSum].next = current.next;
            } else {
                map[prefixSum] = current;
            }
            
            current = current.next;
        }
        
        return dummy.next;
    }
}