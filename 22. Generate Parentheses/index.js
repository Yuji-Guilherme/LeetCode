const backtrack = (openN, closeN, n, result, stack) => {
    if(openN >= n && closeN >= n) {
        result.push(stack.join(''));
        return;
    };

    if(openN < n) {
        stack.push('(');
        backtrack(openN + 1, closeN, n, result, stack);
        stack.pop();
    };

    if(closeN < openN) {
        stack.push(')');
        backtrack(openN, closeN + 1, n, result, stack);
        stack.pop();
    };

    return;
}

var generateParenthesis = function(n) {
    let result = [];
    let stack = [];
    backtrack(0, 0, n, result, stack);

    return result;
};