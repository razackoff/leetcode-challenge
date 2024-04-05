public class Solution {
    public string MakeGood(string s) {
        int l = s.Length;
        if(l == 1)
          return s;
        
        var list = s.ToList();
        MakeGood(list);
        
        return string.Concat(list);
    }

    public void MakeGood(List<char> list)
    {
        int count = 0, diff = 0;
        for(int i = 0; i < list.Count - 1; i++)
        {
            diff = list[i] - list[i + 1];
            if(diff == 32 || diff == -32)
            {
                count++;
                list.RemoveRange(i, 2);
            }
        }
        
        if(count > 0)
           MakeGood(list);
    }
}