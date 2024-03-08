public class Solution {
    public bool IsPalindrome(int x) {
        if(x < 0) return false;

        char[] char1 = x.ToString().ToCharArray();
        char[] char2 = x.ToString().ToCharArray();
        Array.Reverse(char1);

        if(new string(char1) == new string(char2)) return true;
        return false;
    }
}