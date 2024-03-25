public class Solution {
    private Dictionary<string, List<string>> _anagrams;

    public IList<IList<string>> GroupAnagrams(string[] strs) {
        _anagrams = new Dictionary<string, List<string>>();

        for (int i = 0; i < strs.Length; i++) {
            char[] charOfStrs = strs[i].ToCharArray();
            Array.Sort(charOfStrs);
            var sortString = new string(charOfStrs);

            if (!_anagrams.ContainsKey(sortString)) {
                _anagrams.Add(sortString, new List<string>());
            }

            _anagrams[sortString].Add(strs[i]);
        }
        
        return new List<IList<string>>(_anagrams.Values);
    }
}