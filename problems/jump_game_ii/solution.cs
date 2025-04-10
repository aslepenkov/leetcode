public class Solution {
    public int Max(int a, int b) => a>b? a:b;

    public int Jump(int[] nums) {
       int jumps = 0;
       int currentEnd = 0;
       int farthest = 0;

       for (int i = 0; i < nums.Length - 1; i++) {  // no need to consider the last element
           farthest = Max(farthest, i + nums[i]);

           if (i == currentEnd) {
               jumps++;
               currentEnd = farthest;
           }
       }

       return jumps; 
    }
}