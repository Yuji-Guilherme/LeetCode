var addTwoNumbers = function(l1, l2) {
    const head = new ListNode();

    let pointer = head;
    let remainder = 0;
    while (l1 || l2 || remainder) {
        let l1Num = l1 ? l1.val : 0;
        let l2Num = l2 ? l2.val : 0;
        let val = l1Num + l2Num + remainder;

        remainder = ~~(val / 10);
        val %= 10;
        pointer.next = new ListNode(val);

        pointer = pointer.next;
        l1 = l1?.next;
        l2 = l2?.next;
    }

    return head.next;
};

var addTwoNumbers = function(l1, l2, remainder = 0) {
    if (!l1 && !l2 && remainder === 0) return null;

    let l1Num = l1 ? l1.val : 0;
    let l2Num = l2 ? l2.val : 0;
    let total = l1Num + l2Num + remainder;

    remainder = ~~(total / 10);
    total %= 10;

    return new ListNode(total, addTwoNumbers(l1?.next, l2?.next, remainder));
};