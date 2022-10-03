public class Solution {
    public IList<string> FizzBuzz(int n) {
        var res = new List<string>();
        var fz = string.Empty;
        
        for (var i = 1; i <= n; ++i)
        {
            fz = i % 3 == 0 && i % 5==0 ? "FizzBuzz":
                i % 3 == 0  ? "Fizz" :
                    i % 5==0 ? "Buzz": i.ToString();
            res.Add(fz);
        }
        
        return res;
    }
}