const twoSum = function(nums, target) {
    let map = new Map();
    for(var i = 0;i < nums.length; i++) {
        const complement = target - nums[i]
        if(map.has(complement)) return [i, map.get(complement)]
        map.set(nums[i], i)
    }
};

//Acertei o loop de repetição e o complemento mas não o Map. Pensei na solução de 2 loops