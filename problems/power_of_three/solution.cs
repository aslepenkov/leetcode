public class Solution {
    public bool IsPowerOfThree(int n) {
        var a = Math.Log(n) / Math.Log(3);
        return Math.Abs(a - Math.Round(a)) < 1e-10;
    }
}