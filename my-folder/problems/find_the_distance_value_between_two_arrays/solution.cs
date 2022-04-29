public class Solution {
    public int FindTheDistanceValue(int[] arr1, int[] arr2, int d) {
        var res = arr1.Length;
        
        foreach (var a1 in arr1)
            foreach (var a2 in arr2)
                if (Math.Abs(a1-a2) <= d)
                {
                    res--;
                    break;
                }
        return res;
    }
}