var middleNode = function(head) {
    let slowP = head;
    let fastP = head;

    while (slowP !== null && fastP !== null && fastP.next !== null) {
        slowP = slowP.next;
        fastP = fastP.next.next;
    }

    return slowP;
};