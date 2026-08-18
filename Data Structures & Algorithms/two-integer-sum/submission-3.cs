public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        Dictionary<int, int> ans = new Dictionary<int, int>();
        for(int i = 0; i<nums.Length; i++){
            int needed = target - nums[i];
            if(ans.ContainsKey(needed)){
                return new int[] {ans[needed],i};
            }
            else{
                ans[nums[i]] = i;
            }
        }
        return null;
    }
}
