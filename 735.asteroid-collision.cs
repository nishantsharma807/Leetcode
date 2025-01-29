/*
 * @lc app=leetcode id=735 lang=csharp
 *
 * [735] Asteroid Collision
 */

// @lc code=start
public class Solution {
    public int[] AsteroidCollision(int[] asteroids) {
        var stack = new Stack<int>();

        foreach(int asteroid in asteroids) {
            if(asteroid > 0) stack.Push(asteroid);
            else {
                while(stack.Count > 0 && stack.Peek() > 0 
                && stack.Peek() < Math.Abs(asteroid)) {
                    stack.Pop();
                }

                if(stack.Count > 0 && stack.Peek() == Math.Abs(asteroid)) {
                    stack.Pop();
                } else if((stack.Count == 0 && asteroid < 0) || (stack.Peek() < 0 && asteroid < 0)) {
                    stack.Push(asteroid);
                }
            }
        }

        var result = new int[stack.Count];

        for(int i = stack.Count - 1; i >= 0; i--) {
            result[i] = stack.Pop();
        }

        return result;
    }
}
// @lc code=end

