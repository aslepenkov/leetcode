public class Solution {
    public int LengthOfLongestSubstring(string str) {
         var test = string.Empty;
 
        // Result
        var maxLength = -1;
 
        // Return zero if string is empty
        if (string.IsNullOrEmpty(str)) {
            return 0;
        }
        // Return one if string length is one
        else if (str.Length == 1) {
            return 1;
        }
        foreach (char c in str.ToCharArray()) {
            var current = c.ToString();
 
            // If string already contains the character
            // Then substring after repeating character
            if (test.Contains(current)) {
                test = test.Substring(test.IndexOf(current)
                                      + 1);
            }
            test = $"{test}{c}";//test + String.valueOf(c);
            maxLength = Math.Max(test.Length, maxLength);
        }
 
        return maxLength;
    }
}