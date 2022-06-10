public class Solution {
    public int RemoveDuplicates(int[] nums) {
        
        if (nums.Length <= 1)
            return nums.Length;
        
        var shift = 1;
        
        for (int i=1; i<nums.Length; i++)
        {
            if (nums[i] > nums [shift-1])
            {
                nums[shift] = nums[i];
                shift++;
            }
        }
        
        return shift;
    }
}