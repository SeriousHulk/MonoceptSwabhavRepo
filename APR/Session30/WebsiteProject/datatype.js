var x;
console.log(typeof x);

x = 'user';
console.log(typeof x);

x = 10;
console.log(typeof x);

x = null;
console.log(typeof x);

x = undefined;
console.log(typeof x);

x = 10.9;
console.log(typeof x);

//console.log(this == window);

x = function () {
  console.log('inside Function');
};
console.log(typeof x);

x = {
  name1: 'Vikrant',
  compant: 'Monocept',
};
console.log(typeof x);
console.log(this);
