public class Solution {
    private Queue<int> _queue;

    public int CountStudents(int[] students, int[] sandwiches) {
        _queue = new Queue<int>(students);
        int rejectN = 0;
        int sandwicheI = 0;

        while (_queue.Count > rejectN && _queue.Count != 0 && sandwicheI < sandwiches.Length) {
            var student = _queue.Dequeue();

            if (sandwiches[sandwicheI] == student) {
                sandwicheI++;
                rejectN = 0;
            } else {
                _queue.Enqueue(student);
                rejectN++;
            }
        }

        return _queue.Count;
    }
}