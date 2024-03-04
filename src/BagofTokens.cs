public class Solution {
    public int BagOfTokensScore(int[] tokens, int power) {
        int score = 0, d = 1, ans = 0;
        Array.Sort(tokens);
        if(tokens.Length == 0 || power < tokens[0]){
            return 0;
        }
        for(int i = 0; i < tokens.Length; i++){
            if(tokens[i] <= power && tokens[i] != -1){
                power = power - tokens[i];
                score++;
                if(ans < score){
                    ans = score;
                }
            }
            else if(tokens[i] > power && score > 0 && tokens[i] != -1){
                power = power + tokens[tokens.Length - d];
                tokens[tokens.Length - d] = -1;
                score--;
                d++;
                i--;
            }
        }
        return ans;
    }
}