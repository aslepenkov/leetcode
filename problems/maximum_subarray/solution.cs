public class Solution {
    public int MaxSubArray(int[] nums) {
        if(nums.Length <= 0)
            return 0;
        
        var max = nums[0];
        var curr = 0;
        for(var i = 0;i < nums.Length; i++)
        {
            if(curr < 0)
                curr = 0;
            
            curr += nums[i];
            
            if(curr > max)
                max = curr;
            
        }
        return max;
    }
}