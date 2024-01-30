class Solution {
    fun oddEvenList(head: ListNode?): ListNode? {
        var oddhead = ListNode(0)
        var evenhead = ListNode(0)
        var odd = oddhead
        var even = evenhead
        var curr = head
        var flag = 0
        while (curr != null) {
            if (flag % 2 == 0) {
                odd.next = ListNode(curr.`val`)
                odd = odd.next!!
            } else {
                even.next = ListNode(curr.`val`)
                even = even.next!!
            }
            flag++
            curr = curr.next
        }
        odd.next = evenhead.next
        return oddhead.next
    }
}
