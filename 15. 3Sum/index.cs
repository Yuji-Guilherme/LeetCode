public class Solution {
    List<IList<int>> _res = new();

    public IList<IList<int>> ThreeSum(int[] nums) {
        Array.Sort(nums);

        for (int i = 0; i < nums.Length; i++) {
            int n = nums[i];
            int l = i + 1;
            int r = nums.Length - 1;

            if (i > 0 && n == nums[i - 1]) continue;

            while (l < r) {
                int threeSum = n + nums[l] + nums[r];

                if (threeSum < 0) {
                    l++;
                } else if ( threeSum > 0) {
                    r--;
                } else {
                    var newList = new List<int> {n, nums[l], nums[r]};
                    _res.Add(newList);
                    l++;

                    while (nums[l - 1] == nums[l] && l < r) {
                        l++;
                    }
                }
            }
        }
    
    return _res;
    }
}