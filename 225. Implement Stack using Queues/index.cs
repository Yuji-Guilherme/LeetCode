public class MyStack {
    private Queue<int> _queue = new();

    public MyStack() {}
    
    public void Push(int x) {
        _queue.Enqueue(x);
        int size = _queue.Count;
        
        for (int i = 0; i < size - 1; i++) _queue.Enqueue(_queue.Dequeue());
    }
    
    public int Pop() {
        return _queue.Dequeue();
    }
    
    public int Top() {
        return _queue.Peek();
    }
    
    public bool Empty() {
        return _queue.Count == 0;
    }
}