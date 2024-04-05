public class Solution {
    IList<string> ans = new List<string>();
    public IList<string> GenerateParenthesis(int n) {
        Generator("(", 1, 0, n);
        return ans;
    }
    public void Generator(string str, int opened, int closed, int length){
        if(opened + closed == length * 2){
            ans.Add(str);
        }
        if(opened - closed > 0 && opened + closed != 2 * length){
            Generator(str + ")", opened, closed + 1, length);
        }
        if(opened < length){
            Generator(str + "(", opened + 1, closed, length);
        }
    }
}