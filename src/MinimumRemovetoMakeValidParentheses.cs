public class Solution {
    public string MinRemoveToMakeValid(string s) {
        StringBuilder str = new StringBuilder();
        string ss = "";
        int o = 0, c = 0;
        List<int> list = new List<int>();
        for (int i = 0; i < s.Length; i++)
        {
            list.Add(0);
            if (s[i] == '(')
            {
                o++;
                list[i] = 1;
            }
            else if(s[i] == ')')
            {
                c++;
                if (c > o)
                {
                    c--;
                    list[i] = -1;
                }
                else
                {
                    for (int j = i; j >= 0; j--)
                    {
                        if (list[j] == 1)
                        {
                            list[j] = 2;
                            o--;
                            c--;
                            list[i] = 2;
                            break;
                        }
                    }
                }
            }
        }

        for (int i = 0; i < list.Count; i++)
        {
            if (list[i] != -1 && list[i] != 1)
            {
                str.Append(s[i]);
            }
        }
        return str.ToString();
    }
}