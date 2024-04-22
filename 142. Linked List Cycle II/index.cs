public class Solution {
    public ListNode DetectCycle(ListNode head) {
        var slowP = head;
        var fastP = head;
          
        while (slowP != null && fastP != null && fastP.next != null) { 
            slowP = slowP.next; 
            fastP = fastP.next.next;

            if (slowP == fastP) break;
        }

        if (fastP == null || fastP.next == null) return null;

        var slowP2 = head;

        while (slowP != null) {
            if (slowP == slowP2) return slowP;
            slowP = slowP.next;
            slowP2 = slowP2.next;
        }

        return null;
    }
}