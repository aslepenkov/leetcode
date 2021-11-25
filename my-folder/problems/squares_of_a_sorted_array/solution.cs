public class Solution {
    public int[] SortedSquares(int[] nums) {
        
        for(int i =0; i<nums.Length;i++)
        {
            nums[i]*=nums[i];
        }
        return QuickSort(nums,0,nums.Length-1);
    }
    
     private  int[] QuickSort(int[] array, int minIndex, int maxIndex)
        {
            if (minIndex >= maxIndex)
            {
                return array;
            }

            int pivotIndex = GetPivotIndex(array, minIndex, maxIndex);

            QuickSort(array, minIndex, pivotIndex - 1);

            QuickSort(array, pivotIndex + 1, maxIndex);

            return array;
        }

        private  int GetPivotIndex(int[] array, int minIndex, int maxIndex)
        {
            int pivot = minIndex - 1;

            for (int i = minIndex; i <= maxIndex; i++)
            {
               ;
                if (array[i] < array[maxIndex])
                {
                    pivot++;
                    Swap(ref array[pivot], ref array[i]);
                }
            }

            pivot++;
            Swap(ref array[pivot], ref array[maxIndex]);

            return pivot;
        }

        private  void Swap(ref int leftItem, ref int rightItem)
        {
            int temp = leftItem;

            leftItem = rightItem;

            rightItem = temp;
        }
}