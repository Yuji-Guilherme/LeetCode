var pairSum = function(head) {
    let fastP = head;
    let slowP = head;
    let prev = null;

    while(fastP !== null && fastP.next !== null) {
        fastP = fastP.next.next;

        let temp = slowP.next;
        slowP.next = prev;
        prev = slowP;
        slowP = temp;
    }

    let res = 0;

    while(slowP !== null) {
        res = Math.max(res, prev.val + slowP.val);
        prev = prev.next;
        slowP = slowP.next;
    }

    return res;
};