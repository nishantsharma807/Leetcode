/*
 * @lc app=leetcode id=1423 lang=csharp
 *
 * [1423] Maximum Points You Can Obtain from Cards
 */

// @lc code=start
public class Solution {
    public int MaxScore(int[] cardPoints, int k) {
        int maxSum = 0, leftSum = 0, rightSum = 0;

        for(int i = 0; i < k; i++) {
            leftSum += cardPoints[i]; 
        }

        maxSum = leftSum;
        int leftPointer = k - 2;
        int rightPointer = cardPoints.Length - 1;

        while(rightPointer >= cardPoints.Length - k) {
            leftSum -=  cardPoints[leftPointer + 1];
            rightSum +=  cardPoints[rightPointer];
            maxSum = Math.Max(maxSum, leftSum + rightSum);

            leftPointer--;
            rightPointer--;
        }

        return maxSum;
    }
}
// @lc code=end

