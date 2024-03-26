var isValidSudoku = function(board) {
    let rowHash = new Set();
    let colHash = new Map();
    let sqrHash = new Map();

    for (var r = 0; r < 9; r++) {
        for (var c = 0; c < 9; c++) {
            if(board[r][c] !== ".") {
                let sqrIndex = ~~(r/3) * 3 + ~~(c/3);
                let val = board[r][c];

                if(!colHash.has(c)) colHash.set(c, []);
                if(!sqrHash.has(sqrIndex)) 
                    sqrHash.set(sqrIndex, []);

                if(rowHash.has(val) 
                || colHash.get(c).includes(val)
                || sqrHash.get(sqrIndex).includes(val)
                ) return false;

                rowHash.add(val);
                colHash.get(c).push(val);
                sqrHash.get(sqrIndex).push(val);
            }

            if(c === 8) rowHash.clear();
        }
    }

    return true;
};