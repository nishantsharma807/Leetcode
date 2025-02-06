/*
 * @lc app=leetcode id=402 lang=csharp
 *
 * [402] Remove K Digits
 */

// @lc code=start
public class Solution {
    public string RemoveKdigits(string num, int k) {
        var stack = new Stack<char>();

        foreach(char c in num) {
            while(stack.Count > 0 && k > 0 && stack.Peek() > c) {
                stack.Pop();
                k--;
            }

            stack.Push(c);
        }

        //Remove if any remaining from end
        while(k > 0 && stack.Count > 0) {
            stack.Pop();
            k--;
        }

        if(stack.Count == 0) return "0";

        var sb = new StringBuilder();
        while(stack.Count > 0) {
            sb.Insert(0, stack.Pop());
        }

        //Remove leading 0s
        while(sb.Length > 0 && sb[0] == '0') {
            sb.Remove(0, 1);
        }

        return sb.Length == 0 ? "0" : sb.ToString();
    }
}
// @lc code=end

