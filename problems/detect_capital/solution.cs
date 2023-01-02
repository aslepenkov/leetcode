public class Solution {
    public bool DetectCapitalUse(string word) {
    
        if (word.ToUpper() == word)
            return true;

        if (word.ToLower() == word)
            return true;

        if (word.Length > 0 && char.IsUpper(word[0]) 
            && word.Substring(1).ToLower() == word.Substring(1))
            return true;

        return false;
    }
}