public class Solution {
    public int MySqrt(int x) {
        
        if(x < 1) 
            return 0;
        
        long end = x;
        
        while(end > x / end)
        {
            end = (end + x / end) / 2;
        }
        
         return (int)end;
    }
}


