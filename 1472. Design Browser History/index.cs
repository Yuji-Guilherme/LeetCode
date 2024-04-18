public class Node {
    public Node prev;
    public Node next;
    public string value;

    public Node(string url = "") {
        value = url;
    }
}

public class BrowserHistory {
    private Node _current;

    public BrowserHistory(string homepage) {
        _current = new Node(homepage);
    }
    
    public void Visit(string url) {
        var node = new Node(url);
        node.prev = _current;
        _current.next = node;
        _current = _current.next;
    }
    
    public string Back(int steps) {
        while (_current.prev != null && steps > 0) {
            _current = _current.prev;
            steps--;
        }

        return _current.value;
    }
    
    public string Forward(int steps) {
       while (_current.next != null && steps > 0) {
            _current = _current.next;
            steps--;
        }

        return _current.value;
    }
}
