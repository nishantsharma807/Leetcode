/*
 * @lc app=leetcode id=155 lang=csharp
 *
 * [155] Min Stack
 */

// @lc code=start
public class MinStack {
    private Stack<int[]> _stack;

    public MinStack() {
        _stack = new Stack<int[]>();
    }
    
    public void Push(int val) {
        int minValue = val;

        if(_stack.Count > 0) {
            minValue = Math.Min(_stack.Peek()[1], minValue);
        }

        _stack.Push(new int[] { val, minValue });
    }
    
    public void Pop() {
        _stack.Pop();
    }
    
    public int Top() {
        return _stack.Peek()[0];
    }
    
    public int GetMin() {
        return _stack.Peek()[1];
    }
}

/**
 * Your MinStack object will be instantiated and called as such:
 * MinStack obj = new MinStack();
 * obj.Push(val);
 * obj.Pop();
 * int param_3 = obj.Top();
 * int param_4 = obj.GetMin();
 */
// @lc code=end

