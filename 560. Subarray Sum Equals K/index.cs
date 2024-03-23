public class Solution {
    private Dictionary<int, int> _prefixCount;

    public int SubarraySum(int[] nums, int k) {
        int res = 0;
        int currSum = 0;
        _prefixCount = new Dictionary<int, int>();
        _prefixCount[0] = 1;

        for(int i = 0; i < nums.Length; i++) {
            currSum += nums[i];
            int diff = currSum - k;

            if(_prefixCount.ContainsKey(diff)) res += _prefixCount[diff];

            int currSumCount = 0;

            if (_prefixCount.ContainsKey(currSum))
                    currSumCount = _prefixCount[currSum];

            _prefixCount[currSum] = 1 + currSumCount;
        }

        return res;
    }
}