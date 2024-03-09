public class Solution {
    public int RemoveDuplicates(int[] nums) {
        HashSet<int> hs = new HashSet<int>();
        int count = 0;

        for(int i = 0; i < nums.Length; i++) {
            if(hs.Contains(nums[i])) count++;
            hs.Add(nums[i]);
        };
        hs.CopyTo(nums);
        return nums.Length - count;
    }
}