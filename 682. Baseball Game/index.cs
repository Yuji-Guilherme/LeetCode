public class Solution {
    public int CalPoints(string[] operations) {
        var stack = new Stack<int>();

        for (int i = 0; i < operations.Length; i++) {
            if(Int32.TryParse(operations[i], out int j)) stack.Push(j);
            if(operations[i] == "C") stack.Pop();
            if(operations[i] == "D") {
                int num = stack.Peek();
                stack.Push(num * 2);
            };
            if(operations[i] == "+") {
                int num1 = stack.Pop();
                int num2 = stack.Peek();
                stack.Push(num1);
                stack.Push(num1 + num2);
            };
        };

        int[] arr = stack.ToArray();
        return arr.Sum();
    }
}