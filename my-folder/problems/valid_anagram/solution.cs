public class Solution {
    public bool IsAnagram(string s, string t) {
        
        var arr1 = s.ToCharArray();
        var arr2 = t.ToCharArray();

        Array.Sort(arr1);
        Array.Sort(arr2);

        
        return string.Join(",",arr1) == string.Join(",", arr2);
    }
}