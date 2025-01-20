/*
 * @lc app=leetcode id=1698 lang=csharp
 *
 * [1698] Number of Distinct Substrings in a String
 */

// @lc code=start
public class Solution {
    private Node root = new Node();

    public int CountDistinct(string s) {
        int result = 0;

        for(int i = 0; i < s.Length; i++) {
            var node = root;

            for(int j = i; j < s.Length; j++) {
                int index = s[j] - 'a';

                if(node.Links[index] == null) {
                    node.Links[index] = new Node();
                    result++;
                }

                node = node.Links[index];
            }
        }

        return result;
    }
}

public class Node {
    public Node[] Links = new Node[26];
}
// @lc code=end

