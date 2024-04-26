public class Solution {
    private Dictionary<Node, Node> _hashNode = new();

    public Node CopyRandomList(Node head) {
        var headP = head;
        while (headP != null) {
            var copy = new Node(headP.val);
            _hashNode.Add(headP, copy);
            headP = headP.next;
        }

        headP = head;
        while (headP != null) {
            var copy = _hashNode[headP];

            if (headP.next != null) {
                copy.next = _hashNode[headP.next];
            } else {
                copy.next = null;
            }

            if (headP.random != null) {
                copy.random = _hashNode[headP.random];
            } else {
                copy.random = null;
            }

            headP = headP.next;
        };

        return head != null ? _hashNode[head] : null;
    }
}