public class Solution {
    private Stack<int> _stack = new();

    public int EvalRPN(string[] tokens) {
        for (int i = 0; i < tokens.Length; i++) {
            string _case = tokens[i];

            if(Int32.TryParse(_case, out int j)) _stack.Push(j);
            if(_case == "+" || _case == "-" || _case == "*" || _case == "/") {
                int num2 = _stack.Pop();
                int num1 = _stack.Pop();
                int res = Calc(_case, num1, num2);
                _stack.Push(res);
            }
        }

        return _stack.Pop();
    }

    private int Calc(string op, int num1, int num2) {
        switch (op) {
            case "+": return num1 + num2;
            case "-": return num1 - num2;
            case "*": return num1 * num2;
            case "/": return num1 / num2;
            default: return 0;
        }
    }
}