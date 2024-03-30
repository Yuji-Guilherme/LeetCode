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

//Por Recursão

var reverseList = function(head) {
    return Reverse(null, head);      
};

function Reverse(prev, current) {
 if (current == null) return prev;

 var newHead = Reverse(current, current.next);
 current.next = prev;
 return newHead;
};