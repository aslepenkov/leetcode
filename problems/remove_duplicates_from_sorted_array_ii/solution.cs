public class Solution {
    public int RemoveDuplicates(int[] nums) {
        int n = nums.Length;
        if (n <= 2) return n; // Already satisfies the condition

        int writeIndex = 2; // First two elements are always allowed

        for (int i = 2; i < n; i++)
        {
            // Compare with the element two places before
            if (nums[i] != nums[writeIndex - 2])
            {
                nums[writeIndex] = nums[i];
                writeIndex++;
            }
        }

        return writeIndex;
    }
}