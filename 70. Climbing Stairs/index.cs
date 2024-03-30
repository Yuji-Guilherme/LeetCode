public class Solution {
    Dictionary<int, int> _memo;

    public int ClimbStairs(int n) {
        _memo = new Dictionary<int, int>{ {1, 1}, {2, 2}, {3, 3} };
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