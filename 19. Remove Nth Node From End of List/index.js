var removeNthFromEnd = function(head, n) {
    let countP = head;
    let count = 0;

    while (countP.next !== null) {
        countP = countP.next;
        count++;
    }
        
    if ((count + 1) === n) return head.next;
        
    let currentP = head;

    for (var i = 0; i < count - n; i++) currentP = currentP.next;

    if (currentP.next !== null) {
        currentP.next = currentP.next.next;
    } else {
        return null;
    }

    return head;
};