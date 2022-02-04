public class Solution {
    public int StrStr(string haystack, string needle) {
        
       
        
        if (string.IsNullOrEmpty(haystack) && string.IsNullOrEmpty(needle))
            return 0;
        
        if (!string.IsNullOrEmpty(haystack) && string.IsNullOrEmpty(needle))
            return 0;
            
        for(int i = 0; i < haystack.Length; i++)
        {
            if (haystack[i] == needle[0] && haystack.Length >= i+needle.Length)
                for(int j = 0; j < needle.Length; j++)
                {
                    if (haystack[i+j] != needle[j])
                        break;
                    
                    if (j == needle.Length-1)
                        return i;
                }
            
        }
        
        return -1;
    }
}