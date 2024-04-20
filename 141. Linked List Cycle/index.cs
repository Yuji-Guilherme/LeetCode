public class Solution {
    public bool HasCycle(ListNode head) {
        var slowP = head;
        var fastP = head;
          
        while (slowP != null && fastP != null && fastP.next != null) { 
            slowP = slowP.next; 
            fastP = fastP.next.next;

            if (slowP == fastP) return true;
        }

        return false; 
    }
}