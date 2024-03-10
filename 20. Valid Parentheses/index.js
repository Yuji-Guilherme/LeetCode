var isValid = function(s) {
    let stack = [];
    let sArr = s.split('');

    for (let i = 0; i < sArr.length; i++) {
        switch (sArr[i]) {
            case '(':
            case '[':
            case '{':
                stack.push(sArr[i]);
                break;
            case ')':
                    if (stack.length == 0 || stack.pop() != '(') return false;
                    break;
            case '}':
                    if(stack.length == 0 || stack.pop() != '{') return false;
                    break;
            case ']':
                    if(stack.length == 0 || stack.pop() != '[') return false;
                    break;
            default: return false;
        }
    }
        return stack.length === 0;
};