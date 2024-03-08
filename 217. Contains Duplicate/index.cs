public class Solution {
    public bool ContainsDuplicate(int[] nums) {
        if(nums.Length == 1) return false;

        HashSet<int> hs = new HashSet<int>();

        for(int i = 0; i < nums.Length; i++) {
            if(hs.Contains(nums[i])) return true;
            hs.Add(nums[i]);
        }
        return false;
    }
}

//pensei na mesma solução mas não sabia que HashSet exisstia e era mais peformático que List.