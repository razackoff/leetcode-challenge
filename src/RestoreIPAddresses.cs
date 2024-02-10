public class Solution {
    public IList<string> RestoreIpAddresses(string s) {
        if (s.Length > 12)
            return new List<string>();

        var ans = new List<string>();
        for (int i = 0; i <= 3; i++)
        for (int j = 0; j <= 3; j++)
        for (int k = 0; k <= 3; k++)
        for (int l = 0; l <= 3; l++) {
            if (i + j + k + l != s.Length)
                continue;
                
            string part1 = s.Substring(0, i);
            string part2 = s.Substring(i, j);
            string part3 = s.Substring(i + j, k);
            string part4 = s.Substring(i + j + k, l);

            if (IsPartValid(part1) &&
                IsPartValid(part2) &&
                IsPartValid(part3) && 
                IsPartValid(part4)) {
                var res = part1 + "." + part2 + "." + part3 + "." + part4;
                ans.Add(res);
            }
        }

        return ans;
    }

    private bool IsPartValid(string part) {
        if (part == "")
            return false;

        if (part[0] == '0' && part.Length > 1) 
            return false;
        
        int num = int.Parse(part);
        if (num >= 0 && num <= 255)
            return true;

        return false;
    }
}