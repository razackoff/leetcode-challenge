public class Solution {
    public string Multiply(string num1, string num2) {
    
        if (num1 == "0" || num2 == "0")
                return "0";

            char[] num1A = num1.ToCharArray();
            char[] num2A = num2.ToCharArray();

            Array.Reverse(num1A);
            Array.Reverse(num2A);

            int[] ans = new int[num1.Length + num2.Length];
            int digit = 0;

            for (int j = 0; j < num2.Length; j++)
            {
                for( int i = 0; i < num1.Length; i++)
                {
                    digit = (int)Char.GetNumericValue(num1A[i]) * (int)Char.GetNumericValue(num2A[j]);
                    //i+j it's index summation we talked about
                    ans[i + j] += digit % 10;
                    ans[i + j + 1] += digit / 10;

                    if (ans[i+j] >= 10)
                    {
                        ans[i + j + 1] += ans[i + j] / 10;
                        ans[i + j] = ans[i + j] % 10;
                    }
                }

            }
            string answ = "";

            digit = 0;
            for(int k1 = ans.Length-1; k1>= 0; k1--)
            {
                if (ans[k1] == 0 && digit<ans.Length)
                {
                    digit++;
                }
                else
                {
                    digit = ans.Length;
                    answ += ans[k1].ToString();
                }

            }
           

            return answ;
    }
}