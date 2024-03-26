public class Solution {
    public int LengthOfLongestSubstring(string s) {
        string buffer = "", buf = "";
        int f = 0, ans = 0;
        for(int i = 0; i < s.Length; i++){
            f = 0;
            buf = "";
            for(int j = 0;j < buffer.Length; j++){
                if(f == 1){
                    buf += buffer[j];
                }
                if(s[i] == buffer[j]){
                    f = 1;
                }
            }
            if(f == 0){
                buffer = buffer + s[i];
            }
            else{
                buffer = buf + s[i];
            }
            if(buffer.Length > ans){
                ans = buffer.Length;
            }
        }
        return ans;
    }
}