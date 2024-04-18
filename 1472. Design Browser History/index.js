class Node {
    constructor(val, prev, next) {
      this.value = val == undefined ? 0 : val;
      this.prev = prev == undefined ? null : prev;
      this.next = next == undefined ? null : next;
    }
}

var BrowserHistory = function(homepage) {
    this.current = new Node(homepage);
};

BrowserHistory.prototype.visit = function(url) {
    let node = new Node(url, this.current);
    this.current.next = node;
    this.current = this.current.next;
};

BrowserHistory.prototype.back = function(steps) {
    while (this.current.prev && steps > 0) {
        this.current = this.current.prev;
        steps--;
    }

    return this.current.value;
};

BrowserHistory.prototype.forward = function(steps) {
    while (this.current.next && steps > 0) {
        this.current = this.current.next;
        steps--;
    }

    return this.current.value;
};
