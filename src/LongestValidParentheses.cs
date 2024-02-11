public class Solution {
    public int LongestValidParentheses(string s) {
        List<int> list = new List<int>();
        int k = 1, ans = 0;
        for(int i = 0; i < s.Length; i++){
            if(s[i] == '('){
                list.Add(-1);
            }
            else if(s[i] == ')'){
                list.Add(1);
            }
        }
        while(k > 0){
            k--;
            for(int i = 0; i < list.Count; i++){
                if(list[i] > ans && list[i] != 1){
                    ans = list[i];
                }
                if(i > 0 && list[i - 1] >= 2 && list[i] >= 2){
                    list[i - 1] = list[i - 1] + list[i];
                    list.RemoveAt(i);
                    i--;
                    k++;
                }
                if(list[i] == 1 && i - 2 >= 0 && list[i - 2] == -1 && list[i - 1] % 2 == 0){
                    list[i - 2] = 2;
                    list.RemoveAt(i);
                    i--;
                    k++;
                }
                if(i - 1 >= 0 && list[i] == 1 && list[i - 1] == -1){
                    list[i - 1] = 2;
                    list.RemoveAt(i);
                    k++;
                    i--;
                }
            }
        }
        return ans;
    }
}