function add(a, b) {
    return a + b;
}


function subtract(a, b) {
    return a - b;
}


function multiply(a, b) {
    return a * b;
}


function divide(a, b) {
    if (b === 0) {
        throw new Error("Қате: Нөлге бөлуге болмайды!");
    }
    return a / b;
}


const x = 55;
const y = 08;

console.log("Қосу:", add(x, y));           // 16
console.log("Азайту:", subtract(x, y));     // 8
console.log("Көбейту:", multiply(x, y));   // 48
console.log("Бөлу:", divide(x, y));         // 3

try {
    console.log("Бөлу (нөлге):", divide(x, 0));
} catch (error) {
    console.error(error.message); 
}