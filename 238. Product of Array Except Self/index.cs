public class Solution {
    private int[] _resArr; 

    public int[] ProductExceptSelf(int[] nums) {
        int prefix = 1;
        int sufix = 1;
        _resArr = new int[nums.Length];
        _resArr[0] = 1;
        
        for (int i = 0; i < nums.Length -1; i++) {
            prefix *= nums[i];
            _resArr[i+1] = prefix;
        }

        for (int i = nums.Length -1; i > 0; i--) {
            sufix *= nums[i];
            _resArr[i-1] *= sufix;
        }
        
        return _resArr;
    }
}