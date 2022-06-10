using System;
using System.Collections.Generic;

public class Solution {
     public int[] Intersect(int[] nums1, int[] nums2)
        {

            Array.Sort(nums1);
            Array.Sort(nums2);

            var ai = 0;
            var bi = 0;
            var result = new List<int>();

            while (ai < nums1.Length && bi < nums2.Length)
            {
                if (nums1[ai] < nums2[bi])
                {
                    ai++;
                }
                else if (nums1[ai] > nums2[bi])
                {
                    bi++;
                }
                else
                {
                    result.Add(nums1[ai]);
                    ai++;
                    bi++;
                }
            }

            return result.ToArray();
        }
}