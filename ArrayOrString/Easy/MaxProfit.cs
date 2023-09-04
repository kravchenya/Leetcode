namespace LeetCode.ArrayOrString.Easy;

public class MaxProfit
{
    public void CalculateMaxProfit()
    {

        // Example 1:

        // Input: prices = [7,1,5,3,6,4]
        // Output: 5
        // Explanation: Buy on day 2 (price = 1) and sell on day 5 (price = 6), profit = 6-1 = 5.
        // Note that buying on day 2 and selling on day 1 is not allowed because you must buy before you sell.

        // Example 2:

        // Input: prices = [7,6,4,3,1]
        // Output: 0
        // Explanation: In this case, no transactions are done and the max profit = 0.

        // int[] nums2 = new int[] { 7, 1, 5, 3, 6, 4 };
        // int[] nums2 = new int[] { 7, 6, 4, 3, 1 };
        // int[] nums2 = new int[] { 2, 4, 1 };
        int[] nums2 = new int[] { 3, 2, 6, 5, 0, 3 };

        Console.WriteLine("MaxProfit Result " + GetMaxProfig(nums2));
    }

    private int GetMaxProfig(int[] prices)
    {
        int n = prices.Length - 1;
        int result = 0;
        int globalResult = 0;

        int globalMin = Int32.MaxValue;
        int globalMax = Int32.MinValue;

        while (n >= 0)
        {
            int min = Int32.MaxValue;
            int max = Int32.MinValue;
            int minIndex = 0;
            for (int i = 0; i <= n; i++)
            {
                if (prices[i] < min)
                {
                    min = prices[i];
                    minIndex = i;
                } 
            }

            for (int i = minIndex; i <= n; i++)
            {
                if (prices[i] > max)
                {
                    max = prices[i];
                }
            }

            if (n == prices.Length - 1) {
                globalMin = min;
                globalMax = max;
            }

            result = max - min;
            globalResult = globalMax - globalMin;

            if (result > globalResult) {
                globalMin = min;
                globalMax = max;
                globalResult = result;
            }
            n = minIndex - 1;
        }
        return globalResult;
    }
}
