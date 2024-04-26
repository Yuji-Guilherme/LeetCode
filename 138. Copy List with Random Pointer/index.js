var copyRandomList = function(head) {
    const hashNode = new Map();

   let headP = head;
    while (headP !== null) {
        const copy = new Node(headP.val);
        hashNode.set(headP, copy);
        headP = headP.next;
    }

    headP = head;
    while (headP !== null) {
        const copy = hashNode.get(headP);
        copy.next = hashNode.get(headP.next) || null;
        copy.random = hashNode.get(headP.random) || null;
        headP = headP.next;
    };

    return head !== null ? hashNode.get(head) : null;
};