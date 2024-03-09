var calPoints = function(operations) {
    let newArr = [];

    for (let i = 0; i < operations.length; i++) {
        if(parseInt(operations[i])) newArr.push(parseInt(operations[i]));
        if(operations[i] === "C") newArr.pop();
        if(operations[i] === "D") {
            let num = newArr[newArr.length - 1];
            newArr.push(num * 2);
        };
        if(operations[i] === "+") {
            let num = newArr[newArr.length - 1];
            let num2 = newArr[newArr.length - 2];
            newArr.push(num + num2);
        };
    };

    return newArr.reduce((p, v) => p + v, 0);
};