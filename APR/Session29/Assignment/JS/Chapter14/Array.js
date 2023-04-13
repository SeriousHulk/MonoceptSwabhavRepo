var groceries = ['Milk', 'Eggs', 'Frosted Flakes', 'Salami', 'Juice'];
console.log('List of groceries :');
for (var i = 0; i < groceries.length; i++) {
  console.log(groceries[i]);
}
console.log(' ');

groceries.push('Cookies');
console.log('Cookies pushed...');
for (var i = 0; i < groceries.length; i++) {
  console.log(groceries[i]);
}
console.log(' ');

groceries.unshift('Bananas');
console.log('Banans added to start(unshift)...');
for (var i = 0; i < groceries.length; i++) {
  console.log(groceries[i]);
}
console.log(' ');

groceries.pop();
console.log('last item popped...');
for (var i = 0; i < groceries.length; i++) {
  console.log(groceries[i]);
}
console.log(' ');

groceries.shift();
console.log('Banans removed from start(shift)...');
for (var i = 0; i < groceries.length; i++) {
  console.log(groceries[i]);
}
console.log(' ');

console.log('The index of Salami is:' + groceries.indexOf('Salami', 0));
console.log(' ');

var newspapers = ['Lokmat', 'ToI', 'The Hindu', 'Dainik Bhaskar'];

var newList = groceries.concat(newspapers);
console.log('After Concat with newspaper...');
for (var i = 0; i < newList.length; i++) {
  console.log(newList[i]);
}
