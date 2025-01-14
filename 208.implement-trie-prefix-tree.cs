/*
 * @lc app=leetcode id=208 lang=csharp
 *
 * [208] Implement Trie (Prefix Tree)
 */

// @lc code=start
public class Trie {
    private Node root;

    public Trie() {
        root = new Node();
    }
    
    public void Insert(string word) {
        var node = root;

        foreach(char c in word) {
            int index = c - 'a';

            if(node.links[index] == null) {
                node.links[index] = new Node();
            }

            node = node.links[index];
        }

        node.isTerminal = true;
    }
    
    public bool Search(string word) {
        var node = root;

        foreach(char c in word) {
            int index = c - 'a';

            if(node.links[index] != null) node = node.links[index];
            else return false;
        }

        return node.isTerminal;
    }
    
    public bool StartsWith(string prefix) {
        var node = root;

        foreach(char c in prefix) {
            int index = c - 'a';
            if(node.links[index] != null) node = node.links[index];
            else return false;
        }

        return true;
    }
}

public class Node {
    public Node[] links;
    public bool isTerminal;

    public Node() {
        links = new Node[26];
    }
}

/**
 * Your Trie object will be instantiated and called as such:
 * Trie obj = new Trie();
 * obj.Insert(word);
 * bool param_2 = obj.Search(word);
 * bool param_3 = obj.StartsWith(prefix);
 */
// @lc code=end

