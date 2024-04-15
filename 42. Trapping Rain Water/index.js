var trap = function(height) {
    let l = 0;
    let r = height.length - 1;
    let maxL = height[0];
    let maxR = height[height.length -1];
    let res = 0;

    while (l < r) {
        if(maxL < maxR) {
            l++;
            maxL = Math.max(maxL, height[l]);
            res += Math.max(0, maxL - height[l]);
        } else {
            r--;
            maxR = Math.max(maxR, height[r]);
            res += Math.max(0, maxR - height[r]);
        }
    }

    return res;
};