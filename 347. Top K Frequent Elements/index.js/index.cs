public class Solution {
    private Dictionary<int, int> _count;
    private PriorityQueue<KeyValuePair<int, int>, int> _maxQueue;

    public int[] TopKFrequent(int[] nums, int k) {
        _count = new Dictionary<int, int>();
        _maxQueue = new PriorityQueue<KeyValuePair<int, int>, int>();
        var res = new int[k];

        for (int i = 0; i < nums.Length; i++) {
            if(!_count.ContainsKey(nums[i])) {
                _count.Add(nums[i], 1);
                continue;
            }

            _count[nums[i]]++;
        }

        foreach (var item in _count)
        {
            _maxQueue.Enqueue(item, item.Value);
            if (_maxQueue.Count > k)
                _maxQueue.Dequeue();
        }


        for (int i = 0; i < k; i++) {
            res[i] = _maxQueue.Dequeue().Key;
        }

        return res;
    }
}