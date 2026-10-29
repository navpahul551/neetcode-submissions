public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        var ans = new List<List<string>>();
        var dict = new Dictionary<string, List<string>>();
        foreach(var s in strs) {
            string hash = this.HashString(s);
            if(!dict.ContainsKey(hash)) dict[hash] = new List<string>();
            dict[hash].Add(s);
        }
        foreach(var key in dict.Keys) {
            var curr = new List<string>();
            foreach(var s in dict[key]) curr.Add(s);
            ans.Add(curr);
        }
        return ans;
    }

    private string HashString(string s) {
        string hash = "";
        int[] count = new int[26];
        foreach(char c in s) {
            count[c-'a']++;
        }
        foreach(int x in count) hash += Convert.ToString(x) + "-";
        // Console.WriteLine(hash);
        return hash;
    }
}
