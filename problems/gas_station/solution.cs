public class Solution {
    public int CanCompleteCircuit(int[] gas, int[] cost) {
        int totalSurplus = 0; 
        int currentSurplus = 0;
        int startStation = 0;
        
        for (int i = 0; i < gas.Length; i++)
        {
            int netGain = gas[i] - cost[i];
            totalSurplus += netGain;
            currentSurplus += netGain;
            
            // If currentSurplus drops below 0, reset the start station
            if (currentSurplus < 0)
            {
                startStation = i + 1;
                currentSurplus = 0;
            }
        }
     
        return totalSurplus >= 0 ? startStation : -1;
    }
}