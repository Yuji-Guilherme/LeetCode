var findKthLargest = function(nums, k) {
    let newArr = nums.sort((a,b) => b - a);
    return newArr[k-1];
};