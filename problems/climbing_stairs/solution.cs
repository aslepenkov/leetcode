public class Solution {
    public int ClimbStairs(int n) {
        var pre = 1;
        var current = 1;
        var temp = 0;
        
        for (var i = 1; i < n; i++)
        {
            temp = current;
            current += pre;
            pre = temp;
        }
        
        return current;
    }
}