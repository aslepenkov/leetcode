public class Solution {
    public string LongestCommonPrefix(string[] strs) {
        
        var prefix = string.Empty;
        var prefixSB = new StringBuilder();
        var maxPrefix = -1;
        
        for (int i = 0; i < strs[0].Length; i++)
        {
           var ch = strs[0][i];
           var isCommon = true;
            
           for (int j = 0; j < strs.Length; j++)
           {
              if (i >= strs[j].Length || strs[j][i] != ch)
                {
                   isCommon = false; 
                   return prefixSB.ToString();
                   break;
                }
           }
            
           if(isCommon)
                prefixSB.Append(ch);
            
        }
        
        return prefixSB.ToString();
    }
}