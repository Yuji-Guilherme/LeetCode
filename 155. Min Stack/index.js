var MinStack = function() {
    this.stack = [];
    this.minStack = [];
};

MinStack.prototype.push = function(val) {
    this.stack.push(val);

    let currentMinVal = this.minStack[this.minStack.length - 1];

    currentMinVal < val
    ? this.minStack.push(currentMinVal) 
    : this.minStack.push(val);
};

MinStack.prototype.pop = function() {
    this.stack.pop();
    this.minStack.pop();
};

MinStack.prototype.top = function() {
    return this.stack[this.stack.length - 1];
};

MinStack.prototype.getMin = function() {
    return this.minStack[this.minStack.length - 1];
};

//solução com 2 stacks.