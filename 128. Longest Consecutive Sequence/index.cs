public class Solution {
    private HashSet<int> _hashCopy;
    private HashSet<int> _hashResult = new();
    
    public int LongestConsecutive(int[] nums) {
        _hashCopy = new HashSet<int>(nums);
        _hashResult.Add(0);

        foreach (int n in nums) {
            if(!_hashCopy.Contains(n-1)) {
                int length = 0;
                while (_hashCopy.Contains(n + length)) length++;
                _hashResult.Add(length);
            }
        }

        return _hashResult.Max();
    }
}

//solução rapida

public class Solution {
    public int LongestConsecutive(int[] nums) {
        if (nums.Length < 2) return nums.Length;

        Array.Sort(nums);

        var max = 1;
        var lmax = 1;

        for(int i=1; i<nums.Length; i++)
        {
            var diff = nums[i] - nums[i-1];

            if (diff == 1)
            {
                lmax++;   
            }
            else if (diff > 1)
            {
                lmax = 1;
            }
            
            max = Math.Max(max, lmax);
        }

        return max;
    }
}