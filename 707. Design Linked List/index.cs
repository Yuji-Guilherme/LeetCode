public class Node {
    public Node prev;
    public Node next;
    public int value;

    public Node(int val = -1) {
        value = val;
    }
}

public class MyLinkedList {
    private Node _headP = new();
    private Node _tailP = new();
    private int _count;

    public MyLinkedList() {
        _count = 0;
        _headP.next = _tailP;
        _tailP.prev = _headP;
    }
    
    public int Get(int index) {
        var pointer = _headP.next;

        for (int i = 0; i < index; i++) {
            if (pointer != null) {
                pointer = pointer.next;
            } else {
                return -1;
            }
        }

        if (pointer != null) return pointer.value;

        return -1;
    }
    
    public void AddAtHead(int val) {
        var node = new Node(val);
        var prev = _headP;
        var next = _headP.next;

        prev.next = node;
        next.prev = node;
        node.prev = prev;
        node.next = next;
        _count++;
    }
    
    public void AddAtTail(int val) {
        var node = new Node(val);
        var prev = _tailP.prev;
        var next = _tailP;

        prev.next = node;
        next.prev = node;
        node.prev = prev;
        node.next = next;
        _count++;
    }
    
    public void AddAtIndex(int index, int val) {
        if (index > _count) return;

        var pointer = _headP.next;

        for (int i = 0; i < index; i++) {
            if (pointer != null) {
                pointer = pointer.next;
            } else {
                return;
            }
        }

        var node = new Node(val);
        var prev = pointer.prev;
        var next = pointer;

        prev.next = node;
        next.prev = node;
        node.prev = prev;
        node.next = next;
        _count++;

        return;
    }
    
    public void DeleteAtIndex(int index) {
        if (index > _count -1) return;

        var pointer = _headP.next;

        for (int i = 0; i < index; i++) {
            if (pointer != null) {
                pointer = pointer.next;
            } else {
                return;
            }
        }

        pointer.prev.next = pointer.next;
        pointer.next.prev = pointer.prev;
        _count--;        
        
        return;
    }
}
