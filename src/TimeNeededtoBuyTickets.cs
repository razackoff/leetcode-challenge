public class Solution {
    public int TimeRequiredToBuy(int[] tickets, int k) {
        int answer = 0;
        for (int i = 0; i < tickets.Length; i++)
        {
            if (tickets[i] >= tickets[k])
            {
                if (i <= k)
                    answer += tickets[k];
                else
                    answer+= tickets[k]-1;
            }
            else
            {
                answer += tickets[i];
            }
        }
        return answer;
    }
}