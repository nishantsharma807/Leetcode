/*
 * @lc app=leetcode id=346 lang=csharp
 *
 * [346] Moving Average from Data Stream
 */

// @lc code=start
public class MovingAverage {
    private readonly int size;
    private List<int> window = new List<int>();

    public MovingAverage(int size) {
        this.size = size;
    }
    
    public double Next(int val) {
        window.Add(val);
        if(window.Count > size) window.RemoveAt(0);

        int maxLength = Math.Min(window.Count, size);
        double sum = 0;

        for(int i = 0; i < maxLength; i++) {
            sum += window[i];
        }

        return sum/window.Count;
    }
}

/**
 * Your MovingAverage object will be instantiated and called as such:
 * MovingAverage obj = new MovingAverage(size);
 * double param_1 = obj.Next(val);
 */
// @lc code=end

