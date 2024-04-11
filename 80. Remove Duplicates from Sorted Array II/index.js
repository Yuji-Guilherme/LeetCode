var removeDuplicates = function(nums) {
    let replaceIndex = 0;

    for (let i = 0; i < nums.length; i++) {
        if (replaceIndex - 2 >= 0 && nums[replaceIndex - 2] == nums[i]) continue;
            
        nums[replaceIndex] = nums[i];
        replaceIndex++;
    }

    return replaceIndex;
};