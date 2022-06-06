public class Solution {
    public int[] RunningSum(int[] nums) {
        int lastSum = 0;
        
        for (int i = 0; i < nums.Length; i++)
        {
            nums[i] += lastSum;
            lastSum = nums[i];
        }
        
        return nums;
    }
}