var MyStack = function() {
    this.q = [];
};

MyStack.prototype.push = function(x) {
    this.q.push(x);
};

MyStack.prototype.pop = function() {
    return this.q.pop();
};

MyStack.prototype.top = function() {
    return this.q[this.q.length - 1];
};

MyStack.prototype.empty = function() {
    return this.q.length === 0;
};
