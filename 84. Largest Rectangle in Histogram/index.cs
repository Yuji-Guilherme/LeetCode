public class Solution {
    private Stack<int[]> _stack = new();

    public int LargestRectangleArea(int[] heights) {
        int maxA = 0;

        for (int i = 0; i < heights.Length; i++) {
            int h = heights[i];
            int start = i;

            while (_stack.Any() && _stack.Peek()[0] > h) {
                int[] arr = _stack.Pop();
                int height = arr[0];
                int index = arr[1];
                maxA = Math.Max(maxA, height * (i - index));
                start = index;
            }

            _stack.Push([h, start]);
        }

        foreach (int[] arr in _stack) {
            int h = arr[0];
            int i = arr[1];
            maxA = Math.Max(maxA, h * (heights.Length - i));
        }

        return maxA;
    }
}