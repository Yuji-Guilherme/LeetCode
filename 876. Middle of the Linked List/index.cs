public class Solution {
    public ListNode MiddleNode(ListNode head) {
        var slowP = head;
        var fastP = head;

        while (slowP != null && fastP != null && fastP.next != null) { 
            slowP = slowP.next; 
            fastP = fastP.next.next; 
        }

        return slowP;
    }
}