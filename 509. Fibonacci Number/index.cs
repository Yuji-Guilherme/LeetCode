public class Solution {
    Dictionary<int, int> _memo;

    public int Fib(int n) {
        _memo = new Dictionary<int, int>{ {0, 0}, {1, 1}, {2, 1} };
        int result = FibCalc(n);

        return result;
    }

    public int FibCalc(int n) {
        if(_memo.ContainsKey(n)) return _memo[n];

        int FibVal = FibCalc(n-1) + FibCalc(n - 2);

        _memo.Add(n, FibVal);

        return FibVal;
    }
}