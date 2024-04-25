public class Solution {
    public ListNode RemoveNthFromEnd(ListNode head, int n) {
        var countP = head;
        int count = 0;

        while (countP.next != null) {
            countP = countP.next;
            count++;
        }
        
        if ((count + 1) == n) return head.next;
        
        var currentP = head;

        for (int i = 0; i < count - n; i++) currentP = currentP.next;

        if (currentP.next != null) {
            currentP.next = currentP.next.next;
        } else {
            return null;
        }

        return head;
    }
}