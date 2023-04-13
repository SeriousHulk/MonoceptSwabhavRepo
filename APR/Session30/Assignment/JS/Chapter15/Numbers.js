// Strings are different than Numbers

var numberOne = '45';
var numberTwo = 3;
//453
console.log(numberOne + numberTwo);

var numberOne = parseInt('45');
var numberTwo = 3;
//48
console.log(numberOne + numberTwo);

// Math Constants

function getCircumference(radius) {
  return 2 * Math.PI * radius;
}
console.log('Circumference ' + getCircumference(2));

//Rounding
console.log('Rounging off');
console.log(Math.floor(0.5)); // 0
console.log(Math.ceil(0.5)); // 1
console.log(Math.round(0.5)); // 1
console.log(Math.floor(3.14)); // 3
console.log(Math.round(3.14)); // 3
console.log(Math.ceil(3.14)); // 4
console.log(Math.floor(5.9)); // 5
console.log(Math.round(5.9)); // 6
console.log(Math.ceil(5.9)); // 6
