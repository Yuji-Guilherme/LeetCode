public class Solution {
    private Stack<char> _stack = new();
    private List<string> _res = new();

    public IList<string> GenerateParenthesis(int n) {
        BackTrack(0, 0, n);

        return _res;
    }

    private void BackTrack(int openN, int closeN, int n) {
        if(openN == closeN && openN == n && closeN == n) {
            string s = new string(_stack.ToArray());
            _res.Add(s);
            return;
        }

        if(openN < n) {
            _stack.Push(')');
            BackTrack(openN + 1, closeN, n);
            _stack.Pop();
        }

        if(closeN < openN) {
            _stack.Push('(');
            BackTrack(openN, closeN + 1, n);
            _stack.Pop();
        }

        return;
    }
}