/*
 * @lc app=leetcode id=20 lang=csharp
 *
 * [20] Valid Parentheses
 */

// @lc code=start
public class Solution {
    public bool IsValid(string s) {
        if(s.Length % 2 == 1) return false;
        Stack stack = new Stack();

        foreach(char c in s) {
            if(c == '(' || c == '{' || c == '[') {
                stack.Push(c);
            }
            else {
                if(stack.Count == 0) return false;
                var last = (char)stack.Peek();

                if((c == ')' && last != '(') 
                    || (c == '}' && last != '{') 
                    || (c == ']' && last != '[')) {
                    return false;
                }

                stack.Pop();
            }
        }

        return stack.Count == 0;
    }
}
// @lc code=end

