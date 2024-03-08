var isPalindrome = function(x) {
    if(x < 0) return false;

    const rev = x.toString().split('').toReversed().join('');
    
    if(x === parseInt(rev)) return true;

    return false
};