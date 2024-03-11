public class MyHashMap {

    int[] _hs;
    
    public MyHashMap() {
        _hs = new int[1000001];
    }
    
    public void Put(int key, int value) {
        _hs[key] = value + 1;
    }
    
    public int Get(int key) {
        return _hs[key] - 1;
    }
    
    public void Remove(int key) {
        _hs[key] = 0;
    }
}
