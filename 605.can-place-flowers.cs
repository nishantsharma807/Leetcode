/*
 * @lc app=leetcode id=605 lang=csharp
 *
 * [605] Can Place Flowers
 */

// @lc code=start
public class Solution {
    public bool CanPlaceFlowers(int[] flowerbed, int n) {
        if(n == 0) return true;
        int totalPlanted = 0;

        for(int i = 0; i < flowerbed.Length; i++) {
            if(flowerbed[i] == 0) {
                if((i == 0 || flowerbed[i - 1] == 0) 
                && (i == flowerbed.Length - 1 || flowerbed[i + 1] == 0)) {
                    totalPlanted++;
                    if(totalPlanted == n) return true;
                    i++;
                }
            }
        }

        return false;
    }
}
// @lc code=end

