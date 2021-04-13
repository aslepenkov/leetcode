public class Solution {
    public void Rotate(int[] nums, int k) {
        if (nums == null)
            return;
        
        if (nums.Length <=0)
            return;
        
        var a = new int[nums.Length];
        
        for(int i=0; i< nums.Length; i++)
        {
            a[(i+k)% nums.Length] = nums[i];
        }   
        
        for(int i=0; i< nums.Length; i++)
        {
            nums[i] = a[i];
        }
    }
}