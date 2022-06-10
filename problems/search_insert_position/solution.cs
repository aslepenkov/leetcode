public class Solution {
    public int SearchInsert(int[] nums, int target) {
         for (var index = 0; index < nums.Length; index++)
                {
                    if (target <= nums[index])
                    {
                        return index;
                    }
                }
                return nums.Length;
    }
}