/*
 * @lc app=leetcode id=1804 lang=csharp
 *
 * [1804] Implement Trie II (Prefix Tree)
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

            if(node.Links[index] == null) {
                node.Links[index] = new Node();
            }
            node = node.Links[index];
            node.PrefixCount += 1;
        }

        node.EndCount += 1;
    }
    
    public int CountWordsEqualTo(string word) {
        var node = root;

        foreach(char c in word) {
            int index = c - 'a';

            if(node.Links[index] != null) node = node.Links[index];
            else return 0;
        }

        return node.EndCount;
    }
    
    public int CountWordsStartingWith(string prefix) {
        var node = root;

        foreach(char c in prefix) {
            int index = c - 'a';
            if(node.Links[index] != null) node = node.Links[index];
            else return 0;
        }

        return node.PrefixCount;
    }
    
    public void Erase(string word) {
        var node = root;

        foreach(char c in word) {
            int index = c - 'a';
            if(node.Links[index] == null) return;

            node.Links[index].PrefixCount -= 1;
            node = node.Links[index];
        }

        node.EndCount -= 1;
    }
}

public class Node {
    public Node[] Links;
    public int PrefixCount;
    public int EndCount;

    public Node() {
        Links = new Node[26];
    }
}

/**
 * Your Trie object will be instantiated and called as such:
 * Trie obj = new Trie();
 * obj.Insert(word);
 * int param_2 = obj.CountWordsEqualTo(word);
 * int param_3 = obj.CountWordsStartingWith(prefix);
 * obj.Erase(word);
 */
// @lc code=end

