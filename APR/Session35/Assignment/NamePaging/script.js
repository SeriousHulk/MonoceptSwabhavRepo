var names = [
  'Anekant',
  'Ekta',
  'Shubh',
  'Gautam',
  'Manjunath',
  'Ravi',
  'Vikrant',
];

var namePointer = document.querySelector('#name');
let leftBtn = document.querySelector('#leftBtn');
let rightBtn = document.querySelector('#rightBtn');
var count = 0;
namePointer.textContent = names[count];

rightBtn.addEventListener('click', goRight);
leftBtn.addEventListener('click', goLeft);

function goRight() {
  count++;
  namePointer.textContent = names[count];
}
function goLeft() {
  count--;
  namePointer.textContent = names[count];
}
