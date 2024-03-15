var LRUCache = function(capacity) {
    this.cap = capacity;
    this.hash = new Map();
};

LRUCache.prototype.get = function(key) {
    if(this.hash.has(key)) {
        const value = this.hash.get(key);
        this.hash.delete(key);
        this.hash.set(key, value);
        return value;
    };
    return -1;
};

LRUCache.prototype.put = function(key, value) {
    if(this.hash.has(key)) {
        this.hash.delete(key);
    } else if(this.hash.size === this.cap) {
        this.hash.delete(this.hash.keys().next().value);
    };
    
    this.hash.set(key, value);
};