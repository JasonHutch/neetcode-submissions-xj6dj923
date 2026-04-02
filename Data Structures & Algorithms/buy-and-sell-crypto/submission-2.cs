public class Solution {
    public int MaxProfit(int[] prices) {
        // 7,1,5,3,6,4
        //   ^
        //       ^
        
        int left = 0;
        int right = 1;
        int profit = 0;

        while(right < prices.Length)
        {
            int currentProfit = prices[right] - prices[left];

            if(currentProfit <= 0)
            {
                left += 1;
                if(left == right)
                {
                    right+=1;
                }
            }
            else if(currentProfit > 0)
            {
                profit = Math.Max(currentProfit, profit);
                right += 1;
            }
        }

        return profit;
    }
}
 