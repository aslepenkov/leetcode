public class Solution {
    
    public  bool IsRobotBounded(string instructions)
        {
            sbyte dir = 0; //0 1 2 3  -- N E S W
            sbyte[] pos = new sbyte[] { 0, 0 };

            foreach (char inst in instructions)
            {
                switch (inst)
                {
                    case 'G':
                        pos[0] += (dir == 1 || dir == 3) ? dir == (sbyte)1 ? (sbyte)1 : (sbyte)-1 : (sbyte)0;//X
                        pos[1] += (dir == 0 || dir == 2) ? dir == (sbyte)2 ? (sbyte)1 : (sbyte)-1 : (sbyte)0;//Y
                        break;
                    case 'L':
                        dir = (sbyte)((dir + (sbyte)3) % (sbyte)4);
                        break;
                    case 'R':
                        dir = (sbyte)(((sbyte)dir + (sbyte)1) % (sbyte)4);
                        break;
                }
            }
            return pos[0] == 0 && pos[1] == 0 || dir != 0;

        }
}