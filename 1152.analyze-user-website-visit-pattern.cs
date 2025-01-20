/*
 * @lc app=leetcode id=1152 lang=csharp
 *
 * [1152] Analyze User Website Visit Pattern
 */

// @lc code=start
public class Solution {
    public IList<string> MostVisitedPattern(string[] username, int[] timestamp, string[] website) {               
        // Add sites for each user
        var userVisitedMap = new Dictionary<string, List<(int time, string site)>>();
        for(int i = 0; i < username.Length; i++) {
            if(userVisitedMap.ContainsKey(username[i])) userVisitedMap[username[i]].Add((timestamp[i], website[i]));
            else userVisitedMap.Add(username[i], new List<(int, string)>() { (timestamp[i], website[i]) });
        }

        //Sort sites by time
        foreach(var vistedSites in userVisitedMap.Values) {
            vistedSites.Sort((a, b) => a.time.CompareTo(b.time));
        }       

        //Generate all possible triplets with frequency count
        var frequencyMap = new Dictionary<(string, string, string), int>();
        foreach(KeyValuePair<string, List<(int time, string site)>> kvp in userVisitedMap) {
            var sites = kvp.Value.Select(x => x.site).ToList();

            if(sites.Count >= 3) {
                var triplets = GetTriplets(sites);

                foreach((string, string, string) triplet in triplets) {
                    if(frequencyMap.ContainsKey(triplet)) frequencyMap[triplet] += 1;
                    else frequencyMap.Add(triplet, 1);
                }
            }
        }

        int maxCount = 0;
        (string, string, string) result = ("", "", "");

        //Find the triplet with max frequency
        foreach(KeyValuePair<(string, string, string), int> kvp in frequencyMap) {
            if(kvp.Value > maxCount) {
                maxCount = kvp.Value;
                result = kvp.Key;
            } else if (kvp.Value == maxCount && kvp.Key.CompareTo(result) < 0) {
                result = kvp.Key;
            }
        }

        return new List<string>() { result.Item1, result.Item2, result.Item3 };
    }

    private List<(string, string, string)> GetTriplets(List<string> websites) {
        var result = new HashSet<(string, string, string)>();

        for(int i = 0; i < websites.Count; i++) {
            for(int j = i + 1; j < websites.Count; j++) {
                for(int k = j + 1; k < websites.Count; k++) {
                    result.Add((websites[i], websites[j], websites[k]));
                }
            }
        }

        return result.ToList();
    }
}
// @lc code=end

