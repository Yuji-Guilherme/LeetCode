public class Solution {
    public void ReorderList(ListNode head) {
        var slowP = head;
        var fastP = head.next;

        while (fastP != null && fastP.next != null) {
            slowP = slowP.next;
            fastP = fastP.next.next;
        }

        var secondP = slowP.next;
        slowP.next = null;
        ListNode prev = null;

        while (secondP != null) {
            var temp = secondP.next;
            secondP.next = prev;
            prev = secondP;
            secondP = temp;
        }

        var firstP = head;
        secondP = prev;

        while (secondP != null) {
            var temp1 = firstP.next;
            var temp2 = secondP.next;
            firstP.next = secondP;
            secondP.next = temp1;
            firstP = temp1;
            secondP = temp2;
        }
    }
}