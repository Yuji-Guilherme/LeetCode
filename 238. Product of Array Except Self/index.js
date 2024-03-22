/**
 * @param {number[]} nums
 * @return {number[]}
 */
var productExceptSelf = function(nums) {
    let resArr = [];
    let sufix = 1;
    let prefix = 1;
    resArr[0] = 1;

    for (var i = 0; i < nums.length -1; i++) {
        prefix *= nums[i];
        resArr[i+1] = prefix 
    };

    for (var i = nums.length -1; i > 0; i--) {
        sufix *= nums[i];
        resArr[i-1] *= sufix;
    };

    return resArr;
};