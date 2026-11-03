public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        var freq = new Dictionary<int, int>();
        foreach(var x in nums) {
            if(freq.ContainsKey(x)) freq[x]++;
            else freq[x] = 1;
        }

        var set = new SortedSet<(int freq, int num)>();
        foreach(var key in freq.Keys){
            set.Add((freq[key], key));
        }

        var ans = new int[k];
        int i=0;
        foreach(var (f, num) in set.Reverse()) {
            ans[i++] = num;
            if(i == k) break; 
        }
        return ans;
    }
}
