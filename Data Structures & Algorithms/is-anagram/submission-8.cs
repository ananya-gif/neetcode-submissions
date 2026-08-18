public class Solution {
    public bool IsAnagram(string s, string t) {
        Dictionary<char, int> ans = new Dictionary <char, int>();
        if(s.Length != t.Length){
            return false;
        }
        foreach(char c in s){
            if(ans.ContainsKey(c)){
                ans[c]++;
            }
            else{
                ans[c] = 1;
            }
        }
        foreach(char p in t){
            if(ans.ContainsKey(p)){
                ans[p]--;
            }
            else{
                return false;
            }
        }
        foreach(var item in ans){
            if(item.Value != 0){
                return false;
            }
        }
        return true;
    }
}
