var dailyTemperatures = function(temperatures) {
    let stack = [];
    let res = [...temperatures];
    res.fill(0);

    for (let i = 0; i < temperatures.length; i++) {
        let t = temperatures[i];

        while (stack.length > 0 && t > stack.at(-1)[0]) {
            let stackDrop = stack.pop();
            res[stackDrop[1]] = i - stackDrop[1];
        }

        stack.push([t, i]);
    }

    return res;
};