var memo = new Map([[1, 1], [2, 2], [3, 3]]);

var climbStairs = function(n) {
    if(memo.has(n)) return memo.get(n);

    var val = climbStairs(n - 1) + climbStairs(n - 2);

    memo.set(n, val);

    return val;
};