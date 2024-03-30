var sortArray = function(nums) {
    return nums.sort((a, b) => a - b);
};

//merge

const mergeSort = (arr) => {
    if (arr.length < 2) {
        return arr;
    }
    let mid = Math.floor(arr.length / 2);
    let left = mergeSort(arr.slice(0, mid))
    let right = mergeSort(arr.slice(mid))
    return merge(left, right)
}

const merge = (left, right) => {
    const result = []
    let leftIndex = 0, rightIndex = 0;
    while (leftIndex < left.length && rightIndex < right.length) {
        if (left[leftIndex] < right[rightIndex]) {
            result.push(left[leftIndex])
            leftIndex++;
        }
        else {
            result.push(right[rightIndex])
            rightIndex++;
        }
    }

    while (leftIndex < left.length) {
        result.push(left[leftIndex])
        leftIndex++;
    }

    while (rightIndex < right.length) {
        result.push(right[rightIndex])
        rightIndex++;
    }

    return result;
}

var sortArray = function(nums) {
    return mergeSort(nums);
}

//quick sort

const quickSort = (nums, start, end) => {
    if(start>=end) return;
    let left = start, right = end;
    let pivot = nums[Math.floor((start+end)/2)];
    while(left<=right){
        while(left<=right && nums[left]<pivot){
            left++;
        }
        while(left<=right && nums[right] > pivot){
            right--;
        }
        if(left<=right){
            [nums[left], nums[right]] = [nums[right], nums[left]];
            left++;
            right--;
        }
    }
    quickSort(nums, start, right);
    quickSort(nums, left, end);
}

var sortArray = function (nums) {
    let len = nums.length;
    if (len < 2) return nums;

    quickSort(nums, 0, len - 1);
    return nums;
};