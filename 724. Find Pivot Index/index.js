var pivotIndex = function(nums) {
    let total = nums.reduce((p, c) => p + c);
    let lSum = 0;

    for (let i = 0; i < nums.length; i++) {
        let rSum = total - nums[i] - lSum;
        if (rSum === lSum) return i;
        lSum += nums[i];
    };

    return -1;
};