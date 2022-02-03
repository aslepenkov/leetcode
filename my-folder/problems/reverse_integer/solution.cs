public class Solution {
    public int Reverse(int x) {
        long sign = x>=0?1:-1;
        var res = sign * long.Parse(new String(x.ToString().Replace("-",string.Empty).ToCharArray().Reverse().ToArray()));
        
        if (res > int.MaxValue)
            return 0;
        
           if (res < int.MinValue)
            return 0;
        
        return (int) res;

    }
}