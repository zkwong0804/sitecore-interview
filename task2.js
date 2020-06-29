let checkPalindrome =
    (inputString, trashSymbolString) => {
        
        for (
            let i = 0, j = inputString.length - 1;
            i < Math.floor((inputString.length) / 2);
            i++, j--
        ) {
            while (trashSymbolString.includes(inputString[i])) {
                i++;
            }
            while (trashSymbolString.includes(inputString[j])) {
                j--;
            }
            if (inputString[i] !== inputString[j]) return false
        }

        return true;
    }


console.log(checkPalindrome("a@b!!b$a", "!@$"));
console.log(checkPalindrome("?Aaba#c", "#?"));