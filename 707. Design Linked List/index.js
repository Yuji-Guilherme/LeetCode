class Node {
    constructor(val, next) {
      this.value = val == undefined ? 0 : val;
      this.next = next == undefined ? null : next;
    }
}

var MyLinkedList = function() {
    this.head = null;
    this.count = 0;
};

MyLinkedList.prototype.get = function(index) {
    if (index >= this.count) return -1;
      
    let pointer = this.head;
    for (let i = 0; i < index; i++) pointer = pointer.next;
  
    return pointer.value;
};

MyLinkedList.prototype.addAtHead = function(val) {
    let node = new Node(val);
    node.next = this.head;
    this.head = node;
    this.count = this.count + 1;
};

MyLinkedList.prototype.addAtTail = function(val) {
    if (this.head === null) {
        this.addAtHead(val);
        return;
    }
  
    let node = new Node(val);
    let pointer = this.head;
    while (pointer.next !== null) pointer = pointer.next;
  
    pointer.next = node;
    this.count = this.count + 1;
};

MyLinkedList.prototype.addAtIndex = function(index, val) {
    if (index > this.count) return;
      
    if (index === 0) {
        this.addAtHead(val);
        return;
    }
  
    if (index === this.count) {
        this.addAtTail(val);
        return;
    }
  
    let pointer = this.head;
    let node = new Node(val);

    for (let i = 0; i < index-1; i++) pointer = pointer.next;
  
    let next = pointer.next;
    pointer.next = node;
    node.next = next;
    this.count = this.count + 1;
};
  
MyLinkedList.prototype.deleteAtIndex = function(index) {
    if (index >= this.count) return;
  
    if (index === 0) {
        this.head = this.head.next;
        this.count = this.count - 1;
        return;
    }
  
    let pointer = this.head;
    for (let i = 0; i < index - 1; i++) pointer = pointer.next;
  
    pointer.next = pointer.next.next;
    this.count = this.count - 1;
};
  