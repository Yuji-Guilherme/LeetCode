public class Solution {
    private Stack<int[]> _stack = new();
    private int[] _res;

    public int[] DailyTemperatures(int[] temperatures) {
        _res = new int[temperatures.Length];

        for(int i = 0; i < temperatures.Length; i++) {
            int t = temperatures[i];

            while(_stack.Count() != 0 && t > _stack.Peek()[0]) {
                var stackDrop = _stack.Pop();
                _res[stackDrop[1]] = i - stackDrop[1];
            }

            _stack.Push([t, i]);
        }

        return _res;
    }
}