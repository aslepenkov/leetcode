public class Solution {
    public int MaxProfit(int[] prices) {
              
        var min = prices[0];
        var max = int.MinValue;
        
        for(int i = 0; i < prices.Length; i++){
            var money = prices[i] - min;
            if(money > max) 
                max = money;
            if(prices[i] < min) 
                min = prices[i];
        }
        
        return max;
    }
}