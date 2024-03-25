var topKFrequent = function(nums, k) {
    const countMap = new Map();

    for (let i = 0; i < nums.length; i++) {
        if(!countMap.has(nums[i])) countMap.set(nums[i], 0);
        countMap.set(nums[i], countMap.get(nums[i]) + 1);
    }

    const mapToArray = Array.from(countMap,([num, count]) => ({ num, count }));
    mapToArray.sort((a, b) => b.count - a.count);

    return mapToArray.slice(0, k).map(item => item.num);
};