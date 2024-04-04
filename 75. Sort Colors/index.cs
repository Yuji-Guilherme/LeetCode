//bucket sort

public class Solution {
    Dictionary<int, int> _hashCount = new();

    public void SortColors(int[] nums) {
        foreach (int n in nums) {
            if(!_hashCount.ContainsKey(n)) _hashCount.Add(n, 0);
            _hashCount[n]++;
        }

        int _zeroQnt = _hashCount.ContainsKey(0) ? _hashCount[0] : 0;
        int _oneQnt = _hashCount.ContainsKey(1) ? _hashCount[1] : 0;
        int _twoQnt = _hashCount.ContainsKey(2) ? _hashCount[2] : 0;

        if (_hashCount.ContainsKey(0)) {
            int[] _zeroArr = new int[_zeroQnt];
            _zeroArr.CopyTo(nums, 0);
        }
        
        if(_hashCount.ContainsKey(1)) {
            int[] _oneArr = new int[_oneQnt];
            Array.Fill(_oneArr, 1);
            _oneArr.CopyTo(nums, _zeroQnt);
        }

        if(_hashCount.ContainsKey(2)) {
            int[] _twoArr = new int[_twoQnt];
            Array.Fill(_twoArr, 2);
            _twoArr.CopyTo(nums, _zeroQnt + _oneQnt);
        }
    }
}

//Quick Partition

public class Solution {
    public void SortColors(int[] nums) {
        int r = nums.Length -1;
        int l = 0;
        int i = 0;

        while (i <= r) {
            if(nums[i] == 0) {
                Swap(nums, l, i);
                l++;
            }

            if(nums[i] == 2) {
                Swap(nums, i, r);
                r--;
                i--;
            }

            i++;
        }
    }

    private void Swap(int[] nums, int i, int j) {
        int temp = nums[i];
        nums[i] = nums[j];
        nums[j] = temp;
    }
}

//metodo simples

public class Solution {
    public void SortColors(int[] nums) {
        Array.Sort(nums);
    }
}