public class Solution {
    public void ReverseString(char[] s) {
        
        char temp;
        
        for(int i = 0, j=s.Length-1; i< s.Length; i++,j--)
        {
           if (i>=j)
                break;
           if (s[i]==s[j])
               continue;
            
           temp = s[j];
            s[j] = s[i];
            s[i] = temp;
        }
    }
}