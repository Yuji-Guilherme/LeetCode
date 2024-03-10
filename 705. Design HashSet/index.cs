public class MyHashSet {
    byte[] b;

    public MyHashSet() {
        b = new byte[1000001];
    }
    
    public void Add(int key) {
        b[key] = 1;
    }
    
    public void Remove(int key) {
        b[key] = 0;
    }
    
    public bool Contains(int key) {
        return (b[key] == 1);
    }
}