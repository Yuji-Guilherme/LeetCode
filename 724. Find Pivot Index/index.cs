public class Solution {

    private int _total;
    private int _lSum;

    public int PivotIndex(int[] nums) {
        _total = nums.Sum();
        _lSum = 0;

        for (int i = 0; i < nums.Length; i++) {
            int Rsum = _total - nums[i] - _lSum;
            if(Rsum == _lSum) return i;
            _lSum += nums[i];
        };

        return -1;
    }
}