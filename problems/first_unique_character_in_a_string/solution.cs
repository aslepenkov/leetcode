using System.Linq;

public class Solution {
    public int FirstUniqChar(string s) {
        var res = -1;
        
        for(int i=0; i< s.Length;i++)
        {
           if (s.IndexOf(s[i]) == s.LastIndexOf(s[i]))
           {
               return i;
           }
        }
        
        return -1;
    }
}