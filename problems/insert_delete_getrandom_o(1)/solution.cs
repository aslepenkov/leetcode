public class RandomizedSet {
    private List<int> values; // List to store the elements
    private Dictionary<int, int> valToIdx; // Dictionary to store value-to-index mapping
    private Random random;
    public RandomizedSet() {
       values = new List<int>();
       valToIdx = new Dictionary<int, int>();
       random = new Random();
    }
    
    public bool Insert(int val) {
        if (valToIdx.ContainsKey(val))
        {
            return false;
        }
        valToIdx[val] = values.Count;
        values.Add(val);
        return true;
    }
    
    public bool Remove(int val) {
        if (!valToIdx.ContainsKey(val))
        {
            return false; 
        }
        int idxToRemove = valToIdx[val];
        int lastVal = values[values.Count - 1];
        
        values[idxToRemove] = lastVal;
        valToIdx[lastVal] = idxToRemove;

        values.RemoveAt(values.Count - 1);
        valToIdx.Remove(val);
        return true;
    }
    
    public int GetRandom() {
        int randomIdx = random.Next(values.Count);
        return values[randomIdx];
    }
}

/**
 * Your RandomizedSet object will be instantiated and called as such:
 * RandomizedSet obj = new RandomizedSet();
 * bool param_1 = obj.Insert(val);
 * bool param_2 = obj.Remove(val);
 * int param_3 = obj.GetRandom();
 */