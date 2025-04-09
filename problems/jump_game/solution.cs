public class Solution {
    public bool CanJump(int[] nums) {
        //classic greedy
        int farthest = 0;
        for (int i = 0; i < nums.Length; i++) {
            if (i > farthest) {
                return false;
            }
            farthest = Max(farthest, i + nums[i]);
        }
        return true;
    }

    public int Max(int a, int b) => a>b? a:b;
}