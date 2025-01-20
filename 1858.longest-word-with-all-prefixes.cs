/*
 * @lc app=leetcode id=1858 lang=csharp
 *
 * [1858] Longest Word With All Prefixes
 */

// @lc code=start
public class Solution {
    public string LongestWord(string[] words) {
        Trie trie = new Trie();
        string result = "";

        foreach(string word in words) trie.Add(word);

        foreach(string word in words) {
            if(trie.HasPrefix(word)) {
                if(word.Length > result.Length) result = word;
                else if (word.Length == result.Length && string.Compare(word, result) < 0) result = word;
            }
        }

        return result;
    }
}

public class Trie {
    private Node root;

    public Trie() {
        root = new Node();
    }

    public void Add(string word) {
        var node = root;

        foreach(char c in word) {
            int index = c - 'a';

            if(node.Links[index] == null) node.Links[index] = new Node();
            node = node.Links[index];
        }

        node.IsTerminal = true;
    }

    public bool HasPrefix(string word) {
        var node = root;

        foreach(char c in word) {
            int index = c - 'a';

            if(node.Links[index] == null || !node.Links[index].IsTerminal) return false;

            node = node.Links[index]; 
        }

        return true;
    }
}

public class Node {
    public Node[] Links;
    public bool IsTerminal;

    public Node() {
        Links = new Node[26];
    }
}
// @lc code=end

