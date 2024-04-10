//ponteiros

public class Solution {
    public int[] TwoSum(int[] numbers, int target) {
        int l = 0;
        int r = numbers.Length -1;

        while (numbers[l] + numbers[r] != target) {
            if(numbers[l] + numbers[r] < target) l++;

            if(numbers[l] + numbers[r] > target) r--;
        }

        return new int[] { l+1, r+1 };
    }
}

//hashmap

public class Solution {
    private Dictionary<int, int> _map = new();
    
    public int[] TwoSum(int[] numbers, int target) {

        for(int i = 0; i < numbers.Length; i++) {
            int complement = target - numbers[i];
            if(_map.ContainsKey(complement)) {
                return new int[] { _map[complement] +1, i+1 };
            }
            _map[numbers[i]] = i;
        }
        return new int[] { };
    }
}