let field = [
    [0, 1, 0, 0, 0],
    [0, 0, 1, 0, 0],
    [0, 0, 0, 1, 0],
    [0, 0, 0, 1, 0],
    [0, 0, 1, 0, 0],
];
let safePath = [];

// algorighm
for (let i = 0; i < field.length; i++) {
    let safeX = 0;
    let safeY = 0;
    for (let j = 0; j < field[i].length; j++) {
        if (field[i][j] == 1) {
            if (safePath.length <= 0) {
                safePath.push([i, j]);
                console.log(`Totoshka go [${i},${j}]!`)
            } else {
                let last = safePath[safePath.length - 1];
                console.log(`Ally go [${last[0]},${last[1]}]!`);
                if (j == last[1] || j == last[1] - 1 || j == last[1] + 1) {
                    safePath.push([i, j]);
                    console.log(`Totoshka go [${i},${j}]!`);
                }
            }
        }
    }
}

console.log(`Totoshka is safe!`);
console.log(`Ally is safe!`);