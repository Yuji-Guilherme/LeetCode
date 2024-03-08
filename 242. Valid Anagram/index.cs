public class Solution {
    public bool IsAnagram(string s, string t) {
        char[] newS = s.ToCharArray();
        char[] newT = t.ToCharArray();

        Array.Sort(newS);
        Array.Sort(newT);
    
        return new string (newS) ==  new string (newT);
    }
}