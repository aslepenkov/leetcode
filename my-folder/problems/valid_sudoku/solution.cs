using System;
using System.Collections.Generic;

public class Solution {
    public bool IsValidSudoku(char[][] board)
    {
        var hor = new HashSet<char>();
        var vert = new Dictionary<int, HashSet<char>>();
        var sub = new Dictionary<int, HashSet<char>>();


        for (int i = 0; i < board.Length; i++) // lines
        {
            for (int j = 0; j < board[0].Length; j++) // elements in lines
            {
                //skip
                if (board[i][j] != '.')
                  {

                //Horizontals
                if (!hor.Add(board[i][j]))
                    return false;

                //Verticals
                if (!vert.ContainsKey(j))
                    vert.Add(j, new HashSet<char>());

                if (!vert[j].Add(board[i][j]))
                    return false;

                //SubBlocks
                var boxIndex = (i / 3) * 10 + (j / 3);
                if (!sub.ContainsKey(boxIndex))
                    sub.Add(boxIndex, new HashSet<char>());

                if (!sub[boxIndex].Add(board[i][j]))
                    return false;
}
            }
              hor.Clear();
        }

        return true;
    }
}