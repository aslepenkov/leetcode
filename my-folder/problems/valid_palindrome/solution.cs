using System.Text;
using System.Text.RegularExpressions;

public class Solution {
    public bool IsPalindrome(string s) {
        var rgx = new Regex("[^a-zA-Z0-9]");
        s = rgx.Replace(s, "").ToLower();
        
        for(int i=0,j=s.Length-1;i<s.Length/2;i++,j--)
        {
            if(s[i]!=s[j])
                return false;
        }
        return true;
    }
}