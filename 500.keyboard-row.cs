/*
 * @lc app=leetcode id=500 lang=csharp
 *
 * [500] Keyboard Row
 */

// @lc code=start
public class Solution {
    public string[] FindWords(string[] words) {
        var result = new List<string>();
        var row1 = new HashSet<char>("qwertyuiop".ToCharArray());
        var row2 = new HashSet<char>("asdfghjkl".ToCharArray());
        var row3 = new HashSet<char>("zxcvbnm".ToCharArray());

        foreach(string word in words) {
            string lowerWord = word.ToLower();
            var firstCharacter = lowerWord[0];

            HashSet<char> setStrings = row1;

            if(row2.Contains(firstCharacter)) {
                setStrings = row2;
            }
            else if(row3.Contains(firstCharacter)) {
                setStrings = row3;
            }

            bool isValid = true;

            for(int i = 0; i < lowerWord.Length; i++) {
                if(!setStrings.Contains(lowerWord[i])) {
                    isValid = false;
                    break;
                }
            }

            if(isValid) {
                result.Add(word);
            }
        }

        return result.ToArray();
    }
}
// @lc code=end

