public class Solution {
    public string Convert(string s, int numRows) {
        if(numRows == 1){
            return s;
        }
        List<string> ss = new List<string>();
        int k = 1, f = 1;
        for(int i = 0; i <= numRows + 2; i++){
            ss.Add("");
        }
        for(int i = 0; i < s.Length; i++){
            ss[k] += s[i];
            k += f;
            if(k >= numRows){
                f = -1;
            }
            if(k <= 1){
                f = 1;
            }
        }
        string ans = "";
        for(int i = 0; i < ss.Count; i++){
            ans += ss[i];
        }
        return ans;
    }
}