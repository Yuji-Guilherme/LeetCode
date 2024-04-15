public class Solution {
    public int Trap(int[] height) {
        int l = 0;
        int r = height.Length - 1;
        int maxL = height[0];
        int maxR = height[height.Length -1];
        int res = 0;

        while (l < r) {
            if(maxL < maxR) {
                l++;
                maxL = Math.Max(maxL, height[l]);
                res += Math.Max(0, maxL - height[l]);
            } else {
                r--;
                maxR = Math.Max(maxR, height[r]);
                res += Math.Max(0, maxR - height[r]);
            }
        }

        return res;
    }
}