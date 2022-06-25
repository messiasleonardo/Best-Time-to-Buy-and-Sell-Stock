using Best_Time_to_Buy_and_Sell_Stock;
using Xunit;

namespace SolutionTests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(new int[] { 7, 1, 5, 3, 6, 4 }, 5)]
        [InlineData(new int[] { 7, 6, 4, 3, 1 }, 0)]
        [InlineData(new int[] { 1 }, 0)]
        public void Test1(int[] prices, int expected)
        {
            Solution solution = new Solution();

            int actual = solution.MaxProfit(prices);
            int actual2 = solution.MaxProfit2(prices);

            Assert.Equal(expected, actual);
            Assert.Equal(expected, actual2);
        }
    }
}