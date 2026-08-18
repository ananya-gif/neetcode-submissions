public class Solution {
    public bool hasDuplicate(int[] nums) {
        HashSet<int>ans = new HashSet<int>();
        foreach(int num in nums){
            if(!ans.Add(num)){
                return true;
            }
        }
        return false;
    }
}