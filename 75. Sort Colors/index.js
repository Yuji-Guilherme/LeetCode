//bucket sort

var sortColors = function(nums) {
    const count = new Map();

    nums.forEach((v) => {
        if(!count.has(v)) count.set(v, 0);
        count.set(v, count.get(v) + 1);
    });

    const zeroQnt = count.has(0) ? count.get(0) : 0;
    const oneQnt = count.has(1) ? count.get(1) : 0;

    if(count.has(0)) nums.fill(0, 0, zeroQnt);
    if(count.has(1)) nums.fill(1, zeroQnt, oneQnt + zeroQnt);
    if(count.has(2)) nums.fill(2, zeroQnt + oneQnt)
};

//quick partition

var sortColors = function(nums) {
    const swap = (i, j) => {
        const temp = nums[i];
        nums[i] = nums[j];
        nums[j] = temp;
    };

    let r = nums.length - 1;
    let l = 0;
    let i = 0;

    while (i <= r) {
        if(nums[i] == 0) {
            swap(l, i);
            l++;
        }

        if(nums[i] == 2) {
            swap(i, r);
            r--;
            i--;
        }

        i++;
    };
};

//simple

var sortColors = function(nums) {
    nums.sort();
};