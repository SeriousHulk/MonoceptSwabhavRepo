f1();
function f1() {
  console.log('Inside f1');
}

// Expression Function hoisting not happing
var f2 = function () {
  console.log('Inside f2, function Expression');
};
f2();

f3();
function f3() {
  console.log('Inside function f3, function statement');
  for (var i = 1; i <= 10; i++) {
    console.log(i);
  }
  console.log('after hoisting value of i:' + i);
}
console.log('Outside function value of i is :' + i);
