public class Solution {
    public int MajorityElement(int[] nums) {
        int candidate = 0;
        int count = 0;

        //Boyer-Moore Voting Algorithm
        foreach (int num in nums)
        {
            if (count == 0)
            {
                candidate = num;
            }
            if (num == candidate)
            {
                count++;
            }
            else
            {
                count--;
            }
        }
        return candidate;
    }
}