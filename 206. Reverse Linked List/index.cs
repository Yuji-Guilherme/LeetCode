public class Solution {
    public ListNode ReverseList(ListNode head) {
        if (head == null || head.next == null) return head;
        
        ListNode prv = null;
        var cur = head;

        while (cur != null) {
            var post = cur.next;
            cur.next = prv;
            prv = cur;
            cur = post;
        }

        return prv;
    }
}