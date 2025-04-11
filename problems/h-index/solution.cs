public class Solution {
    public int HIndex(int[] citations)
    {
        int n = citations.Length;
        int[] counts = new int[n + 1]; // Counting array
        
        // Step 1: Populate the counts array
        foreach (int c in citations)
        {
            if (c >= n)
            {
                counts[n]++; // Count papers with citations >= n
            }
            else
            {
                counts[c]++; // Count papers with citations < n
            }
        }
        
        // Step 2: Calculate h-index by traversing the counts array backward
        int total = 0;
        for (int h = n; h >= 0; h--)
        {
            total += counts[h]; // Accumulate the count of papers
            if (total >= h) // Check if the condition for h-index is satisfied
            {
                return h;
            }
        }

        return 0; // Default case, should not be reached
    }
    
}