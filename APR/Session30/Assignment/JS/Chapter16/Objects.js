//Declaring an Object
var person = {};
person.firstName = 'Ram';
person.lastName = 'Narayan';

var person = {};
person['firstName'] = 'Ram';
person['lastName'] = 'Narayan';

var person = {
  firstName: 'Ram',
  lastName: 'Narayan',
  getName: function () {
    return 'Name is: ' + this.firstName + ' ' + this.lastName;
  },
};

console.log(person.getName());
