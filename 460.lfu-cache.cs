/*
 * @lc app=leetcode id=460 lang=csharp
 *
 * [460] LFU Cache
 */

// @lc code=start
public class LFUCache {
    private readonly int capacity = 0;    
    int minFrequency = 0;
    int currCapacity = 0;
    
    Dictionary<int, Node> cache;
    Dictionary<int, DoubleLinkedList> frequencyMap;

    public LFUCache(int capacity) {
        this.capacity = capacity;
        cache = new Dictionary<int, Node>();
        frequencyMap = new Dictionary<int, DoubleLinkedList>();
    }
    
    public int Get(int key) {
        if(!cache.ContainsKey(key)) return -1;

        var node = cache[key];
        UpdateNode(node);
        return node.val;
    }
    
    public void Put(int key, int value) {
        if (capacity == 0) return;

        if(cache.ContainsKey(key)) {
            var node = cache[key];
            node.val = value;
            UpdateNode(node);
        } else {
            //If capacity has reached max value, remove lru node from minFrequencyList
            if(currCapacity == capacity) {
                var minFrequencyList = frequencyMap[minFrequency];
                if (minFrequencyList != null && minFrequencyList.size > 0) {
                    var lastNode = minFrequencyList.tail.prev;
                    cache.Remove(lastNode.key);
                    minFrequencyList.RemoveNode(lastNode);
                    currCapacity--;
                }
            }

            //Reset minFrequency as new node is added
            minFrequency = 1;
            var node = new Node(key, value);
            cache.Add(key, node);
            
            if(!frequencyMap.ContainsKey(minFrequency)) {
                frequencyMap.Add(minFrequency, new DoubleLinkedList());
            }

            var newDll = frequencyMap[minFrequency];
            newDll.AddNode(node);
            currCapacity++;
        }
    }

    //Remove from old frequency and add to new frequency
    public void UpdateNode(Node node) {
        int freq = node.frequency;
        var dll = frequencyMap[freq];
        dll.RemoveNode(node);

        //If minFrequency has no nodes remaining, update minFrequency
        if(minFrequency == freq && dll.size == 0) {
            minFrequency++;
        }

        node.frequency++;
        if(!frequencyMap.ContainsKey(freq + 1)) {
            frequencyMap.Add(freq + 1, new DoubleLinkedList());
        }

        var newDll = frequencyMap[freq + 1];
        newDll.AddNode(node);
    }
}

public class DoubleLinkedList {
    public int size;
    public Node head;
    public Node tail;

    public DoubleLinkedList() {
        size = 0;
        head = new Node(-1, -1);
        tail = new Node(-1, -1);

        head.next = tail;
        tail.prev = head;
    }

    public void AddNode(Node node) {
        var next = head.next;
        head.next = node;
        node.next = next;
        node.prev = head;
        next.prev = node;
        size++;
    }

    public void RemoveNode(Node node) {
        var prev = node.prev;
        var next = node.next;
        prev.next = next;
        next.prev = prev;

        size--;
    }
}

public class Node {
    public int key;
    public int val;
    public int frequency;
    public Node next;
    public Node prev;

    public Node(int key, int val) {
        this.key = key;
        this.val = val;
        this.frequency = 1;
    }
}

/**
 * Your LFUCache object will be instantiated and called as such:
 * LFUCache obj = new LFUCache(capacity);
 * int param_1 = obj.Get(key);
 * obj.Put(key,value);
 */

/**
 * Your LFUCache object will be instantiated and called as such:
 * LFUCache obj = new LFUCache(capacity);
 * int param_1 = obj.Get(key);
 * obj.Put(key,value);
 */
// @lc code=end

