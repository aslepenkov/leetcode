public class Solution {
    public int SingleNumber(int[] nums) {
        var output = 0;
        
        for (int i = 0; i < nums.Length; i++)
        {
            output = output^nums[i];  
        }
        
        return output;
    }
}