public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        var ans = new Dictionary<string, List<string>>();
        foreach(string word in strs){
            char[] chars = word.ToCharArray();
            Array.Sort(chars);
            string words = new string(chars);
            if(ans.ContainsKey(words)){
                ans[words].Add(word);
            }
            else{
                ans[words] = new List<string>{word};
            }
        }
        return ans.Values.ToList();
    }
}
