public class Solution {
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2) {
        var head = new ListNode();

        var pointer = head;
        int remainder = 0;
        while (l1 != null || l2 != null || remainder != 0) {
            int l1Num = l1 != null ? l1.val : 0;
            int l2Num = l2 != null ? l2.val : 0;
            int val = l1Num + l2Num + remainder;

            remainder = val / 10;
            val = val % 10;
            pointer.next = new ListNode(val);

            pointer = pointer.next;
            l1 = l1?.next;
            l2 = l2?.next;
        }

        return head.next;
    }
}

//Por recursão

public class Solution {
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2, int remainder = 0) {
        if (l1 == null && l2 == null && remainder == 0) return null;

        int l1Num = l1 != null ? l1.val : 0;
        int l2Num = l2 != null ? l2.val : 0;
        int total = l1Num + l2Num + remainder;

        remainder = total / 10;

        return new ListNode(total % 10,  AddTwoNumbers(l1?.next, l2?.next, remainder));
    }

}