/*
 * @lc app=leetcode id=17 lang=csharp
 *
 * [17] Letter Combinations of a Phone Number
 */

// @lc code=start
public class Solution {
    private Dictionary<char, string> map = new Dictionary<char, string> 
    {
        { '2', "abc" }, { '3', "def" },  { '4', "ghi" }, { '5', "jkl" },
        { '6', "mno" }, { '7', "pqrs" }, { '8', "tuv" }, { '9', "wxyz" }
    };

    private List<string> result = new List<string>();
    private string _digits;

    public IList<string> LetterCombinations(string digits) {
        if(digits.Length == 0) return result;
        _digits = digits;

        BackTrack(0, new StringBuilder());

        return result;
    }

    private void BackTrack(int index, StringBuilder sb) {
        //Each number will correspond to 1 char on keypad
        if(sb.Length == _digits.Length) {
            result.Add(sb.ToString());
            return;
        }

        string keyPadValue = map[_digits[index]];

        foreach(char c in keyPadValue) {
            sb.Append(c);
            BackTrack(index + 1, sb);
            sb.Remove(sb.Length - 1, 1);
        }
    }
}
// @lc code=end

