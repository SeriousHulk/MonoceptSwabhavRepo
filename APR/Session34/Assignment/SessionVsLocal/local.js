localStorage.setItem('username', 'John Doe');
localStorage.setItem('age', 30);

const username = localStorage.getItem('username');
const age = localStorage.getItem('age');

console.log(username);
console.log(age);

localStorage.setItem('age', 31);