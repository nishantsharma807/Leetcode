/*
 * @lc app=leetcode id=682 lang=csharp
 *
 * [682] Baseball Game
 */

// @lc code=start
public class Solution {
    public int CalPoints(string[] operations) {
        var stack = new Stack<int>();

        foreach(string op in operations) {
            if(op == "C") {
                stack.Pop();
            }
            else if (op == "D") {
                stack.Push(stack.Peek() * 2);
            }
            else if (op == "+") {
                int num2 = stack.Pop();
                int num1 = stack.Peek();
                
                stack.Push(num2);
                stack.Push(num1 + num2);
            }
            else {
                stack.Push(Int32.Parse(op));
            }
        }

        int result = 0;
        
        while(stack.Count > 0) {
            result += stack.Pop();
        }

        return result;
    }
}
// @lc code=end

