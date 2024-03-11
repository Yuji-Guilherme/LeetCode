var NumArray = function(nums) {
    let pref = [nums[0]];

    for (let i = 1; i < nums.length; i++) {
        pref[i] = pref[i - 1] + nums[i];
    };

    this.pref = pref;
};

NumArray.prototype.sumRange = function(left, right) {
    if (left === 0) return this.pref[right];
    return this.pref[right] - this.pref[left - 1];
};