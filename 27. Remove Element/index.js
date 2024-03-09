var removeElement = function(nums, val) {
    var count = 0;

    for (var i = 0; i < nums.length; i++) {
        if(nums[i] === val) continue;
            nums[count] = nums[i];
            count++;
    };

    return count;
};