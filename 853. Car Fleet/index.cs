public class Solution {
    private Stack<double> _stack = new();

    public int CarFleet(int target, int[] position, int[] speed) {
        if (position.Length == 1) return 1;

        Array.Sort(position, speed);

        for (int i = 0; i < position.Length; i++) {
            int p = position[i];
            int s = speed[i];
            var c = ((double)target - (double)p) / (double)s;

            while (_stack.Any() && c >= _stack.Peek()) {
                _stack.Pop();
            }

            _stack.Push(c);
        }

        return _stack.Count();
    }
}