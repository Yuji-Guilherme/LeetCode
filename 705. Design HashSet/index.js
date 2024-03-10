var MyHashSet = function() {
    this.hs = {};
};

MyHashSet.prototype.add = function(key) {
    this.hs[key] = 1;
};

MyHashSet.prototype.remove = function(key) {
    delete this.hs[key];
};

MyHashSet.prototype.contains = function(key) {
    return !!this.hs[key];
};