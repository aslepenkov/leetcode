public class Solution {
    public int[] TwoSum(int[] numbers, int target) {
        var result = new int[2];
        var i = 0;
        var j = numbers.Length - 1;
        var temp = -1;
 
        while (i <= j) {
            temp = numbers[i] + numbers[j];
            if (temp < target) {
                i++;
            } else if (temp > target) {
                j--;
            } else {
                result[0] = i + 1;
                result[1] = j + 1;
                return result;
            }
        }
        return result;
    }
}