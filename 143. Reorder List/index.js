var reorderList = function(head) {
    let slowP = head, fastP = head.next;

    while (fastP != null && fastP.next != null) {
        slowP = slowP.next;
        fastP = fastP.next.next;
    }

    let secondP = slowP.next;
    let prev = slowP.next = null;

    while (secondP != null) {
        let temp = secondP.next;
        secondP.next = prev;
        prev = secondP;
        secondP = temp;
    }

    let firstP = head;
    secondP = prev;

    while (secondP != null) {
        let temp1 = firstP.next, temp2 = secondP.next;
        firstP.next = secondP;
        secondP.next = temp1;
        firstP = temp1;
        secondP = temp2;
    }
};