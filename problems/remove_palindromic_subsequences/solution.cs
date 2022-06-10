public class Solution {
    public int RemovePalindromeSub(string s) {
        
        if (s.Length == 0)
            return 0;
        var left = 0;
        var right = s.Length - 1;
        
        while (left < right) {
            // palindrome condition
            if (s.ElementAt(left) == s.ElementAt(right)) {
                left++;
                right--;
            }
            else 
                return 2;
        }
        return 1; 
    }
}