public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        var dict = new Dictionary<int, (int, int)>();
        int[] ans = new int[2];
        ans[0] = ans[1] = -1;
        int n = nums.Length;

        for(int i=0; i < n; i++) {
            int x = nums[i];
            if(dict.ContainsKey(target-x)){
                ans[1] = i;
                ans[0] = dict[target-x].Item2;
                break;
            }
            else {
                dict[x] = (target-x, i);
            }
        }


        return ans;
    }
}
