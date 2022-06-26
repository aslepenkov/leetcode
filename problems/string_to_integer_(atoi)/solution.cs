public class Solution {
    public int MyAtoi(string str) {
     
    str = str.Trim();
    if (String.IsNullOrEmpty(str))
		return 0;
        
    if (str == null || str.Length < 1)
		return 0;
 
	// trim white spaces
	
 
	char flag = '+';
 
	// check negative or positive
	int i = 0;
	if (str.ElementAt(0) == '-') {
		flag = '-';
		i++;
	} else if (str.ElementAt(0) == '+') {
		i++;
	}
	// use double to store result
	double result = 0;
 
	// calculate value
	while (str.Length > i && str.ElementAt(i) >= '0' && str.ElementAt(i) <= '9') {
		result = result * 10 + (str.ElementAt(i) - '0');
		i++;
	}
 
	if (flag == '-')
		result *= -1;
 
	// handle max and min
	if (result > Int32.MaxValue)
		return Int32.MaxValue;
 
	if (result < Int32.MinValue)
		return Int32.MinValue;
 
	return (int) result;
    }
}