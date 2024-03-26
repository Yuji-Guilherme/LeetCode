public class Solution {
    private HashSet<char> _rowHash = new();
    private Dictionary<int, List<char>> _colHash = new();
    private Dictionary<(int, int), List<char>> _square = new();

    public bool IsValidSudoku(char[][] board) {
        for (int r = 0; r < 9; r++) {
            for(int c = 0; c < 9; c++) {
                if(board[r][c] != '.') {
                    int sqrRow = r/3;
                    int sqrCol = c/3;

                    if(!_colHash.ContainsKey(c)) _colHash[c] = new List<char>();
                    if(!_square.ContainsKey((sqrRow, sqrCol))) 
                        _square[(sqrRow, sqrCol)] = new List<char>();

                    if(_rowHash.Contains(board[r][c]) ||
                        _colHash[c].Contains(board[r][c]) ||
                        _square[(sqrRow, sqrCol)].Contains(board[r][c])
                    ) return false;

                    _rowHash.Add(board[r][c]);
                    _colHash[c].Add(board[r][c]);
                    _square[(sqrRow, sqrCol)].Add(board[r][c]);
                }
                    
                if(c == 8) _rowHash.Clear();
            }
        }
             
        return true;
    }
}