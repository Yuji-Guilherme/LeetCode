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

//Por recursão

public class Solution {
    public ListNode ReverseList(ListNode head) {
        return Reverse(null, head);
            
        static ListNode Reverse(ListNode prev, ListNode current)
        {
            if (current == null)
                return prev;

            var newHead = Reverse(current, current.next);
            current.next = prev;
            return newHead;
        }
    }
}
