public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        int n = nums.Length;
        int[] answer = new int[n];
        
        // answer = prefix*suffix
        // Step 1: Compute prefix products and store in answer
        int prefix = 1;
        for (int i = 0; i < n; i++)
        {
            answer[i] = prefix; 
            prefix *= nums[i];
        }
        
        // Step 2: Compute suffix products and update the answer array
        int suffix = 1;
        for (int i = n - 1; i >= 0; i--)
        {
            answer[i] *= suffix;
            suffix *= nums[i]; 
        }
        
        return answer;
    }
}