public class Solution {
    public bool CheckValidString(string s)
    {
        var used = new List<int>();
        int o = 0, c = 0, ms = 0;
        for (int i = 0; i < s.Length; i++)
        {
            used.Add(0);
            if (s[i] == '(')
            {
                o++;
            }
            else if (s[i] == ')')
            {
                if (o > 0)
                {
                    for (int j = i - 1; j >= 0; j--)
                    {
                        if (s[j] == '(' && used[j] == 0)
                        {
                            used[j] = 1;
                            used[i] = 1;
                            o--;
                            break;
                        }
                    }
                }
                else
                {
                    c++;
                }
            }
            else
            {
                ms++;
            }
        }

        Console.WriteLine("- " + ms + " " + o + " " + c);
        
        if (c > 0)
        {
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == ')' && used[i] == 0 && ms > 0)
                {
                    for (int j = i - 1; j >= 0; j--)
                    {
                        if (s[j] == '*' && used[j] == 0)
                        {
                            used[j] = 1;
                            used[i] = 1;
                            c--;
                            ms--;
                            break;
                        }
                    }
                }
            }
        }

        if (o > 0)
        {
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == '(' && used[i] == 0 && ms > 0)
                {
                    for (int j = i + 1; j < s.Length; j++)
                    {
                        if (s[j] == '*' && used[j] == 0)
                        {
                            used[j] = 1;
                            used[i] = 1;
                            o--;
                            ms--;
                            break;
                        }
                    }
                }
            }
        }
        
        if (o > 0 || c > 0)
        {
            return false;
        }
        
        return true;
    }
}