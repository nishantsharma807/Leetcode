/*
 * @lc app=leetcode id=953 lang=csharp
 *
 * [953] Verifying an Alien Dictionary
 */

// @lc code=start
public class Solution {
    public bool IsAlienSorted(string[] words, string order) {
        var orderDictionary = new Dictionary<char, int>();

        for (int i = 0; i < order.Length; i++)
        {
            orderDictionary.Add(order[i], i);
        }

        for (int i = 0; i < words.Length - 1; i++) {
            var currWord = words[i];
            var nextWord = words[i + 1];
            var maxLenToCheck = Math.min(currWord.Length, nextWord.Length);


            for(int j = 0; j < maxLenToCheck; j++) {

                var currWordCharValue = orderDictionary[currWord[j]];
                var nextCharValue = orderDictionary[currWord[j]];

                if (currWordCharValue > nextCharValue) {
                    return false;
                } 
                else if(currWordCharValue < nextCharValue) {
                    //words are in sequence, move to next word
                    break;
                }

            }
        }

        return true;
    }
}
// @lc code=end

