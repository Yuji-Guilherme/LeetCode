var reverseList = function(head) {
    if (head == null || head.next == null) return head;
    
    var prv = null;
    var cur = head;

    while (cur != null) {
        var post = cur.next;
        cur.next = prv;
        prv = cur;
        cur = post;
    }

    return prv;
};