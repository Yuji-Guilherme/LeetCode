public class Solution {
    public int[] GetConcatenation(int[] nums) {
        var n = nums.Length;
        var ans = new int[2*n];
        nums.CopyTo(ans, 0);
        nums.CopyTo(ans, n);
        return ans;
    }
}