public class Solution 
{
    public int HammingWeight(uint n) 
    {
        string s = Convert.ToString(n,2);
        int x = 0;
        foreach(char c in s)
        {
            if(c == '1')
            {
                x++;
            }
        }
        return x;
    }
}