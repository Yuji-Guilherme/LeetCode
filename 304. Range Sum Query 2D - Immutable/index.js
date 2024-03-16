var NumMatrix = function(matrix) {
    let row = matrix.length + 1;
    let col = matrix[0].length + 1;
       this.newMatrix = Array.from({length: row}, () => new Array(col).fill(0));

       for (let i = 1; i < row; i++)
           for (let j = 1; j < col; j++) {
               this.newMatrix[i][j] = matrix[i-1][j-1] 
                               + this.newMatrix[i-1][j] 
                               + this.newMatrix[i][j-1] 
                               - this.newMatrix[i-1][j-1];
           }
   
};

NumMatrix.prototype.sumRegion = function(row1, col1, row2, col2) {
       let c2 = col2 + 1;
       let r2 = row2 + 1;

      return this.newMatrix[r2][c2] 
               - this.newMatrix[r2][col1] 
               - this.newMatrix[row1][c2] 
               + this.newMatrix[row1][col1];
  
};