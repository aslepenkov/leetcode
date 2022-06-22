public class Solution {
    public int PivotIndex(int[] nums) {
        var sum = 0;
        var leftSum = 0;
        
		foreach (var i in nums)
			sum += i;
		for (int i = 0; i < nums.Length; i++) {
			if (leftSum == sum - leftSum - nums[i])
				return i;
			leftSum += nums[i];
		}
        
		return -1;
    }
}