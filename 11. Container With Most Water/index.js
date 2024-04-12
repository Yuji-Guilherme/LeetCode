var maxArea = function(height) {
    let res = 0;
    let l = 0;
    let r = height.length - 1;

    while (l < r) {
        let area = Math.min(height[r], height[l]) * (r - l);
        res = Math.max(res, area);

        if (height[l] < height[r]) {
            l++;
        } else {
            r--;
        }
    }

    return res;
};