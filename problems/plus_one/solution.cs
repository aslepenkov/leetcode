public class Solution {
    public int[] PlusOne(int[] digits) {
       for (int i = digits.Length - 1; i >= 0; i--) {
            if (digits[i] != 9) {
                digits[i]++;
                break;
            } else {
                digits[i] = 0;
            }
        }
        if (digits[0] == 0) {
            var rst = new int[digits.Length + 1];
            rst[0] = 1;
            return rst;
        }
        return digits;
    }
}