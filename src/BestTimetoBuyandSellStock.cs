public class Solution {
    public int MaxProfit(int[] prices) {
        int minPrice = int.MaxValue;
        int maxProfit = 0;
        
        for (int i = 0; i < prices.Length; i++) {
            if (prices[i] < minPrice) {
                minPrice = prices[i];
            }
            
            int profit = prices[i] - minPrice;
            if (profit > maxProfit) {
                maxProfit = profit;
            }
        }
        
        return maxProfit;
    }
}