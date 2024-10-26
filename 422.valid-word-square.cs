/*
 * @lc app=leetcode id=422 lang=csharp
 *
 * [422] Valid Word Square
 */

// @lc code=start
public class Solution {
    public bool ValidWordSquare(IList<string> words) {
        int maxLength = words.OrderByDescending(s => s.Length).First().Length;
        
        for(int i = 0; i < maxLength; i++) {
            if(maxLength > words.Count) return false;

            var currentWord = words[i];
            var colWord = "";
            foreach(string word in words) {
                if(i > word.Length -1) break;
                colWord += word[i];
            }

            if(currentWord != colWord) return false;
        }

        return true;
    }
}
// @lc code=end

