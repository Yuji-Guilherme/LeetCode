var largestRectangleArea = function(heights) {
    let maxA = 0;
    let stack = [];

    for (let i = 0; i < heights.length; i++) {
        let h = heights[i];
        let start = i;

        while (stack.length > 0 && stack.at(-1)[0] > h) {
            let [height, index] = stack.pop();
            maxA = Math.max(maxA, height * (i - index));
            start = index;
        }

        stack.push([h, start]);
    }

    stack.forEach((arr) => {
        let [h, i] = arr;
        maxA = Math.max(maxA, h * (heights.length - i));
    })

    return maxA;
};