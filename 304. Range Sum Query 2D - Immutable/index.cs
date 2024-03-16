public class NumMatrix {
    private readonly int[,] _matrix;
    
    public NumMatrix(int[][] matrix) 
    {
        int col = matrix[0].Length;
        _matrix = new int[matrix.GetLength(0)+1, col+1];
        for(int i = 0; i  < matrix.GetLength(0); i++)
            for(int j = 0; j < col; j++)
            {
                _matrix[i+1, j+1] = _matrix[i, j+1] 
                                    + _matrix[i+1, j] 
                                    + matrix[i][j] 
                                    - _matrix[i,j];
            }
    }
    
    public int SumRegion(int row1, int col1, int row2, int col2) 
    {
        return _matrix[row2+1, col2+1] 
                - _matrix[row2+1, col1] 
                - _matrix[row1, col2+1] 
                + _matrix[row1, col1];    
    }
}public class NumMatrix {
    private readonly int[,] _matrix;
    
    public NumMatrix(int[][] matrix) 
    {
        int col = matrix[0].Length;
        _matrix = new int[matrix.GetLength(0)+1, col+1];
        for(int i = 0; i  < matrix.GetLength(0); i++)
            for(int j = 0; j < col; j++)
            {
                _matrix[i+1, j+1] = _matrix[i, j+1] 
                                    + _matrix[i+1, j] 
                                    + matrix[i][j] 
                                    - _matrix[i,j];
            }
    }
    
    public int SumRegion(int row1, int col1, int row2, int col2) 
    {
        return _matrix[row2+1, col2+1] 
                - _matrix[row2+1, col1] 
                - _matrix[row1, col2+1] 
                + _matrix[row1, col1];    
    }
}public class NumMatrix {
    private readonly int[,] _matrix;
    
    public NumMatrix(int[][] matrix) 
    {
        int col = matrix[0].Length;
        _matrix = new int[matrix.GetLength(0)+1, col+1];
        for(int i = 0; i  < matrix.GetLength(0); i++)
            for(int j = 0; j < col; j++)
            {
                _matrix[i+1, j+1] = _matrix[i, j+1] 
                                    + _matrix[i+1, j] 
                                    + matrix[i][j] 
                                    - _matrix[i,j];
            }
    }
    
    public int SumRegion(int row1, int col1, int row2, int col2) 
    {
        return _matrix[row2+1, col2+1] 
                - _matrix[row2+1, col1] 
                - _matrix[row1, col2+1] 
                + _matrix[row1, col1];    
    }
}