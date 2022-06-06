public class Solution {
    public int[][] Transpose(int[][] matrix) {
        var result = new int[matrix[0].Length][];
        
        for (int x = 0; x < matrix[0].Length; x++) 
        {
            result[x] =  new int[matrix.Length];
            for (int y = 0; y < matrix.Length; y++) 
            {
                result[x][y] = matrix[y][x]; //Change result x,y to input x,y
            }
        }
        return result;
    }
}