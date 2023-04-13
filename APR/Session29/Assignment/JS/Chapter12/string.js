var stringA = 'I am a simple string.';
var stringB = 'I am a simple string, too!';
console.log('String Concatenation: str1:' + stringA + ' str2:' + stringB);

var textA = 'Please';
var textB = new String('stop!');
var combined = textA + ' make it ' + textB;
console.log(combined);

var foo = 'I really';
var blah = 'why anybody would';
var blarg = 'do this';
var result = foo.concat(" don't know", ' ', blah, ' ', blarg);
console.log(result);

var theBigString = 'Pulp Fiction is an awesome movie!';
console.log(theBigString.slice(5, 12));

var theBigString = 'Pulp Fiction is an awesome movie!';
console.log(theBigString.slice(0, -6));

var theBigString = 'Pulp Fiction is an awesome movie!';
console.log(theBigString.slice(-14, -7));

var inspirationalQuote =
  'That which you can concatenate, you can also split apart.';
var splitWords = inspirationalQuote.split(' ');
console.log(splitWords.length);
