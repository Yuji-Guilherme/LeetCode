var hasCycle = function(head) {
    let slowP = head;
    let fastP = head;
          
    while (slowP !== null && fastP !== null && fastP.next !== null) { 
        slowP = slowP.next; 
        fastP = fastP.next.next;

        if (slowP === fastP) return true;
    }

    return false; 
};