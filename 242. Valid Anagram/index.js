var isAnagram = function(s, t) {
    if(s.length != t.length) return false;

    const sArr = s.split('').sort().toString();
    const tArr = t.split('').sort().toString();

    if(sArr == tArr) return true;
    return false;
};