// question 1
let a = 5
let b = 10
a = a + b
b = a - b
a = a - b
console.log(a)
console.log(b)

// question 2

let max = 0
let numbers = [4, 9, 2, 7, 5]
for(let i = 0; i < numbers.length - 1; i++){
    if(numbers[i] > numbers[i + 1] && numbers[i] > max){
        max = numbers[i]
    }
}
console.log(max)

// question 3

let str = "JavaScript is awesome"
let vowels = ["a", "e", "i", "o", "u"]
let count = 0;
for(let letter of str.toLowerCase()){
    if(vowels.includes(letter)){
        count++
    }
}
console.log(`The number of vowels is ${count}`)

// question 4

function checkPrime(num){
    if(num <= 2){
        return false;
    }
    for(i = 2; i < Math.sqrt(num); i++){
        if(num % i == 0){
            return false
        }
    }
    return true;
}
console.log(checkPrime(23))

// question 5

function reverseString(str){
    let reversedStr = ""
    for(let i = (str.length - 1); i > -1; i--){
        reversedStr += str[i]
    }
    return reversedStr
}
console.log(reverseString("hello"))

// question 6

let nums = [1, 2, 3, 4, 5, 6];
let sumOfEvens = 0
for (let num of nums){
    if(num % 2 == 0){
        sumOfEvens += num
    }
}
console.log(sumOfEvens)

// question 7

let arr = [1, 2, 3, 2, 4, 1, 5];
let uniqueArr = [...new Set(arr)];

console.log(uniqueArr);

// question 8

for(i = 1; i <= 30; i++){
    if(i % 5 == 0 && i % 3 == 0){
        console.log("FuzzBuzz")
    }else if(i % 5 == 0){
        console.log("Buzz")
    }else if(i % 3 == 0){
        console.log("Fuzz")
    }else{
        console.log(i)
    }
}

// question 9

function factorial(num) {
    if (num < 0) {
        return 0;
    }
    if (num == 0 || num == 1) {
        return 1;
    }
    return num * factorial(num - 1);
}

console.log(factorial(5));

// question 10

let car = { brand: "Toyota", model: "Corolla", year: 2020, color: "blue" };
for (let key in car) {
    console.log(`${key}: ${car[key]}`);
}