public class Solution {
    public int PairSum(ListNode head) {
        var fastP = head;
        var slowP = head;
        ListNode prev = null;

        while (fastP != null && fastP.next != null) {
            fastP = fastP.next.next;

            var temp = slowP.next;
            slowP.next = prev;
            prev = slowP;
            slowP = temp;
        }

        int res = 0;

        while (slowP != null) {
            res = Math.Max(res, prev.val + slowP.val);
            prev = prev.next;
            slowP = slowP.next;
        }

        return res;
    }
}