public class Solution {
    public void Rotate(int[][] arr) {
        var n = arr.Length;
 
 
        for(int i = 0; i < n; i++)
        {
            for(int j = 0; j < n - i; j++)
            {
                int temp = arr[i][j];
                arr[i][j] = arr[n - 1 - j][n - 1 - i];
                arr[n - 1 - j][n - 1 - i] = temp;
            }
        }

      
        for(int i = 0; i < n / 2; i++)
        {
            for(int j = 0; j < n; j++)
            {
                int temp = arr[i][j];
                arr[i][j] = arr[n - 1 - i][j];
                arr[n - 1 - i][j] = temp;
            }
        }
    }
}