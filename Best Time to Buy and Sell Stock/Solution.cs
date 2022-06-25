namespace Best_Time_to_Buy_and_Sell_Stock
{
    public class Solution
    {
        public int MaxProfit(int[] prices)
        {
            if (prices.Length >= Math.Pow(10,5))
            {
                return 0;
            }

            List<int> result = new List<int>();

            for (int i = 0; i < prices.Length; i++)
            {
                for (int j = i+1; j < prices.Length; j++)
                {
                    result.Add(prices[j] - prices[i]);
                }
            }

            if (result.Count == 0)
            {
                return 0;
            }

            if (result.Max() < 0)
            {
                return 0;
            }
            return result.Max();
        }

        public int MaxProfit2(int [] prices)
        {
            int left = 0;
            int right = 1;
            int max_profit = 0;

            while (right < prices.Length)
            {
                if (prices[left] < prices[right])
                {
                    int profit = prices[right] - prices[left];

                    max_profit = Math.Max(max_profit, profit);
                }
                else
                {
                    left = right;
                }
                right++;
            }

            return max_profit;

        }
    }
}