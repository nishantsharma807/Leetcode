/*
 * @lc app=leetcode id=150 lang=csharp
 *
 * [150] Evaluate Reverse Polish Notation
 */

// @lc code=start
public class Solution {
    public int EvalRPN(string[] tokens) {
        int result = 0;
        var stack = new Stack<int>();

        foreach(string token in tokens) {
            if(Int32.TryParse(token, out int value)) {
                stack.Push(value);
            }
            else {
                int num2 = stack.Pop();
                int num1 = stack.Pop();

                switch (token) {
                    case "+":
                        result = num1 + num2;
                        break;
                    case "-":
                        result = num1 - num2;
                        break;
                    case "*":
                        result = num1 * num2;
                        break;
                    case "/":
                        result = num1 / num2;
                        break;
                }
                stack.Push(result);
            }
        }

        return stack.Pop();
    }
}
// @lc code=end

