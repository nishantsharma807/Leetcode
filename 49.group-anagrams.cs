/*
 * @lc app=leetcode id=49 lang=csharp
 *
 * [49] Group Anagrams
 */

// @lc code=start
public class Solution {
    public IList<IList<string>> GroupAnagrams(string[] strs) {
        var map = new Dictionary<string, List<string>>();

        foreach(string str in strs) {
            var sortedString = SortString(str);

            if(map.ContainsKey(sortedString)) {
                map[sortedString].Add(str);
            }
            else {
                map.Add(sortedString, new List<string> { str });
            }
        }

        return new List<IList<string>>(map.Values);
    }

    private string SortString(string input)
    {
        char[] characters = input.ToArray();
        Array.Sort(characters);
        return new string(characters);
    }
    }
}
// @lc code=end

