var names = [];
console.log(names);

names.push('VIKRANT');
names.push('Kadam');
names.push('Monocept');
names.unshift('Nanded');
console.log(names);

names.forEach((n) => console.log(n.toUpperCase()));

var names_with_a = names.filter((name) => name.includes('a'));
console.log(names_with_a);
var strNos = ['10', '20', '30', '40'];
var sum = strNos.map((no) => parseInt(no)).reduce((a, b) => a + b);
console.log(sum);

var users = [
  { id: 101, name: 'Anekant', salary: 1000 },
  { id: 102, name: 'Vikrant', salary: 2000 },
];
var sum = 0;

for (var i = 0; i < users.length; i++) {
  sum += users[i].salary;
}

console.log('Sum of salaries:', sum);
