var longestConsecutive = function(nums) {
    if (nums.length < 2) return nums.length;

    nums.sort((a, b) => a - b);

    let max = 1;
    let lmax = 1;

    for(var i = 1; i < nums.length; i++) {
        var diff = nums[i] - nums[i-1];

        if (diff == 1) lmax++;
 
        if (diff > 1) lmax = 1;
            
        max = Math.max(max, lmax);
    }

    return max;
};