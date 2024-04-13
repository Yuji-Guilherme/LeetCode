var threeSum = function(nums) {
    nums.sort((a, b) => a - b);
    let res = [];

    for (let i = 0; i < nums.length; i++) {
        let n = nums[i];
        let l = i + 1;
        let r = nums.length - 1;

        if (i > 0 && n == nums[i - 1]) continue;

        while (l < r) {
            let threeSum = n + nums[l] + nums[r];

            if (threeSum < 0) {
                l++;
            } else if ( threeSum > 0) {
                r--;
            } else {
                res.push([n, nums[l], nums[r]]);
                l++;

                while (nums[l - 1] == nums[l] && l < r) {
                        l++;
                    }
                }
            }
        }
    
    return res;
};