public class Solution {
    public string MaximumOddBinaryNumber(string s) {
        int l = s.Length, ones = 0, i = 0;
        string ans = "";
        foreach (char ch in s){
            if (ch == '1'){
                ones++;
            }
        }
        while (i < ones - 1){
            ans += "1";
            i++;
        }
        while (i < l - 1){
            ans += "0";
            i++;
        }
        ans += "1";

        return ans;
    }
}