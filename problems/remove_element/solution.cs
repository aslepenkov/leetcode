public class Solution {
    public int RemoveElement(int[] nums, int val) {
        int k = 0;

        // Iterate through the array
        for (int i = 0; i < nums.Length; i++) {
            // If the current element is not equal to val
            // Place it at position k and increment k
            if (nums[i] != val) {
                nums[k] = nums[i];
                k++;
            }
        }

        return k;
    }
}