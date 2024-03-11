public class NumArray {

    private int[] _pref;

    public NumArray(int[] nums) {
        _pref = new int[nums.Length];
        _pref[0] = nums[0];

        for (int i = 1; i < nums.Length; i++) {
            _pref[i] = _pref[i-1] + nums[i];
        };
    }
    
    public int SumRange(int left, int right) {
        if(left == 0) return _pref[right];
        return _pref[right] - _pref[left - 1];
    }
}