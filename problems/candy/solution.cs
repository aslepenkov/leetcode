public class Solution {
    private int Max(int a, int b) => a > b ? a : b;
    public int Candy(int[] ratings) {
        int n = ratings.Length;
        int[] candies = new int[n];
        
        // Step 1: Assign 1 candy to each child initially
        for (int i = 0; i < n; i++)
            candies[i] = 1;

        // Step 2: Left to right pass
        for (int i = 1; i < n; i++)
        {
            if (ratings[i] > ratings[i - 1])
                candies[i] = candies[i - 1] + 1;
        }

        // Step 3: Right to left pass
        for (int i = n - 2; i >= 0; i--)
        {
            if (ratings[i] > ratings[i + 1])
                candies[i] = Max(candies[i], candies[i + 1] + 1);
        }

        // Step 4: Sum up the candies
        int totalCandies = 0;
        for (int i = 0; i < n; i++)
            totalCandies += candies[i];

        return totalCandies;
    }
}