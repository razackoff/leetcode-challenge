public class Solution {
    public string CustomSortString(string order, string s) {
        string ans = "";
        List<int> used = new();
        for(int j = 0; j < s.Length; j++){
            used.Add(0);
        }
        for(int i = 0; i < order.Length; i++){
            for(int j = 0; j < s.Length; j++){
                if(order[i] == s[j] && used[j] == 0){
                    used[j] = 1;
                    ans += s[j];
                }
            }
        }
        for(int j = 0; j < s.Length; j++){
            if(used[j] == 0){
                ans += s[j];
            }
        }
        return ans;
    }
}