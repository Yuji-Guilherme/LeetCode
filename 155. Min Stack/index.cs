public class MinStack {

    private List<int> _l;
    private int _i;

    public MinStack() {
        _l = new List<int>();
        _i = 0;
    }
    
    public void Push(int val) {
        _l.Insert(_i, val);
        _i++;
    }
    
    public void Pop() {
        _l.RemoveAt(_l.Count - 1);
        _i--;
    }
    
    public int Top() {
        return _l.Last();
    }
    
    public int GetMin() {
        return _l.Min();
    }
}

//solução sem stack.