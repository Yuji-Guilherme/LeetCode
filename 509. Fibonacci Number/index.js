var memo = new Map([[0, 0], [1, 1], [2, 1]]);

var fib = function(n) {
    if(memo.has(n)) return memo.get(n);

    var val = fib(n - 1) + fib(n - 2);

    memo.set(n, val);

    return val;
};