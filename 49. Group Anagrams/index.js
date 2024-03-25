var groupAnagrams = function(strs) {
    let anagrams = new Map();

    for (var i = 0; i < strs.length; i++) {
        const sortString = [...strs[i]].sort().join();

        if(!anagrams.has(sortString)) anagrams.set(sortString, []);

        anagrams.get(sortString).push(strs[i]);
    }

    return [...anagrams.values()];
};