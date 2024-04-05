const calc = (op, num1, num2) => {
    switch (op) {
        case "+": return num1 + num2;
        case "-": return num1 - num2;
        case "*": return num1 * num2;
        case "/": return Math.trunc(num1 / num2);
        default: return 0;
    }
}

var evalRPN = function(tokens) {
    let stack = [];

    for (let i = 0; i < tokens.length; i++) {
        const token = tokens[i];

        if(!isNaN(token)) stack.push(parseInt(token));
        if(token === "+" || token === "-" || token === "*" || token === "/") {
                let num2 = stack.pop();
                let num1 = stack.pop();
                let res = calc(token, num1, num2);
                stack.push(res);
        }
    }

    return stack[0];
};