var twoSum = function(numbers, target) {
    let l = 0;
    let r = numbers.length -1;

    while (numbers[l] + numbers[r] !== target) {
        if(numbers[l] + numbers[r] < target) l++;

        if(numbers[l] + numbers[r] > target) r--;
    }

    return [l+1, r+1];
};