/**
 * @param {number[]} nums
 * @param {number} k
 * @return {number}
 */
var subarraySum = function(nums, k) {
    let res = 0;
    let currSum = 0;
    let prefixCount = new Map();
    prefixCount[0] = 1;

    for(var i = 0; i < nums.length; i++) {
        currSum += nums[i];
        let diff = currSum - k;

        res += prefixCount[diff] || 0;
            
        prefixCount[currSum] = 1 + (prefixCount[currSum] || 0);       
    }

    return res;
};