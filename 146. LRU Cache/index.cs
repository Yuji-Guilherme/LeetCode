public class Node {
    public Node Prev;
    public Node Next;
    public int Key;
    public int Value;

    public Node(int key, int value) {
        Key =  key;
        Value = value;
    }
}

public class LRUCache {

    private Dictionary<int, Node> _cache;
    private readonly int _cap;
    private Node _lruPointer;
    private Node _recentPointer;

    public LRUCache(int capacity) {
        _cache = new Dictionary<int, Node>();
        _cap = capacity;

        _lruPointer = new Node(0, 0);
        _recentPointer = new Node(0, 0);
        _lruPointer.Next = _recentPointer;
        _recentPointer.Prev = _lruPointer;
    }
    
    public int Get(int key) {
        if(_cache.ContainsKey(key)) {
            RemoveNode(_cache[key]);
            InsertNode(_cache[key]);
            return _cache[key].Value;
        } 
        return -1;
    }
    
    public void Put(int key, int value) {
        if(_cache.ContainsKey(key)) {
            RemoveNode(_cache[key]);
            _cache.Remove(key);
        };
        var _currentNode = new Node(key, value);
        _cache.Add(key, _currentNode);
        InsertNode(_currentNode);

        if(_cache.Count() > _cap) {
            var lru = _lruPointer.Next;
            RemoveNode(lru);
            _cache.Remove(lru.Key);
        }
    }

    public void RemoveNode(Node node) {
        Node previous = node.Prev;
        Node next = node.Next;
        previous.Next = next;
        next.Prev = previous;
    }

    public void InsertNode(Node node) {
        node.Prev = _recentPointer.Prev;
        node.Next = _recentPointer;
        _recentPointer.Prev.Next = node;
        _recentPointer.Prev = node;
    }
}

// Solução com Node criado;

public class LRUCache {

    private Dictionary<int,LinkedListNode<int>> _cache;
    private LinkedList<int> _list;
    private readonly int _cap;

    public LRUCache(int capacity) {
        _cache = new Dictionary<int,LinkedListNode<int>>();
        _cap = capacity;
        _list = new LinkedList<int>();
    }
    
    public int Get(int key) {
        if(!_cache.ContainsKey(key)) {
            return -1;
        }
        var node = _cache[key];
        if (node.List == null) {
            _cache.Remove(key);
            return -1;
        }   
        _list.Remove(node);
        _list.AddFirst(node);
        return node.Value;
    }
    
    public void Put(int key, int value) {
        if(_cache.ContainsKey(key)) {
            var node = _cache[key];
            if (node.List != null) {
                node.Value = value;
                _list.Remove(node);
                _list.AddFirst(node);
                return;
            } else  _cache.Remove(key);
        };
        if (_list.Count == _cap) _list.RemoveLast();
        var newNode = _list.AddFirst(value);
        _cache.Add(key, newNode);
    }
}

//solução com linked list;
