public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        var ans = new Dictionary<int,int>();
        List<int>[] buckets = new List<int>[nums.Length + 1];
        for(int i = 0; i < buckets.Length; i++){
            buckets[i] = new List<int>();
        }
        foreach(int num in nums){
            if(ans.ContainsKey(num)){
                ans[num]++;
            }
            else{
                ans[num] = 1;
            }
        }
        foreach(var item in ans){
            buckets[item.Value].Add(item.Key);
        }

        int[] result = new int[k];
        int index = 0;
        for(int i = buckets.Length - 1; i > 0; i--){
            foreach(int n in buckets[i]){
                result[index++] = n;
                if(index == k){
                    return result;
                }
            }

        }
        return result;
    }
}
