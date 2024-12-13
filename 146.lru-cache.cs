/*
 * @lc app=leetcode id=146 lang=csharp
 *
 * [146] LRU Cache
 */

// @lc code=start
public class LRUCache {
    Node head, tail;
    Dictionary<int, Node> dictionary;
    int capacity = 0;

    public LRUCache(int capacity) {
        this.capacity = capacity;
        head = new Node(0, 0);
        tail = new Node(0, 0);
        dictionary = new Dictionary<int, Node>();
        head.next = tail;
        tail.prev = head;
    }
    
    public int Get(int key) {
        int value = -1;

        if(dictionary.ContainsKey(key)) {
            Node node = dictionary[key];
            Remove(node);
            Insert(node);
            value = node.value;
        }

        return value;
    }
    
    public void Put(int key, int value) {
        if(dictionary.ContainsKey(key)) {
            Remove(dictionary[key]);
        }
        
        if(dictionary.Count == capacity) {
            Remove(tail.prev);
        }

        Node node = new Node(key, value);
        Insert(node);
    }

    public void Insert(Node node) {
        var currNext = head.next;
        head.next = node;
        node.prev = head;
        node.next = currNext;
        currNext.prev = node;

        dictionary.Add(node.key, node);
    }

    public void Remove(Node node) {
        var currNext = node.next;
        var currPrev = node.prev;

        currPrev.next = currNext;
        currNext.prev = currPrev;

        dictionary.Remove(node.key);
    }
}

public class Node {
    public Node prev, next;
    public int key, value;

    public Node(int _key, int _value) {
        key = _key;
        value = _value;
    }
}

/**
 * Your LRUCache object will be instantiated and called as such:
 * LRUCache obj = new LRUCache(capacity);
 * int param_1 = obj.Get(key);
 * obj.Put(key,value);
 */
// @lc code=end

