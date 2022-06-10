public class Solution {
    public int PeakIndexInMountainArray(int[] arr) {
        var lo = 0;
        var hi = arr.Length - 1;
        while (lo < hi) {
            var mi = lo + (hi - lo) / 2;
            if (arr[mi] < arr[mi + 1])
                lo = mi + 1;
            else
                hi = mi;
        }
        return lo;
    }
}