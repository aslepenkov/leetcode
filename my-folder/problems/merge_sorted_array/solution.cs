public class Solution {
    public void Merge(int[] nums1, int m, int[] nums2, int n) {
        var mergedArr = new int[m+n];
        int i = 0, j = 0, k = 0;
        
        while (i < m && j < n)
        {
            if (nums1[i] < nums2[j])
                mergedArr[k++] = nums1[i++];
            else
                mergedArr[k++] = nums2[j++];
        }
        
        while (i < m)
            mergedArr[k++] = nums1[i++];
     
        while (j < n)
            mergedArr[k++] = nums2[j++];
        
        Array.Copy(mergedArr, nums1, m+n);
    }
}