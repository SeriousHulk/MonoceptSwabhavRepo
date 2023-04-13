function isAnagrams(str1, str2) {
  str1 = str1.toLowerCase();
  str2 = str2.toLowerCase();
  if (str1.length !== str2.length) {
    return false;
  }
  let charArr1 = str1.split('').sort();
  let charArr2 = str2.split('').sort();
  for (let i = 0; i < charArr1.length; i++) {
    if (charArr1[i] !== charArr2[i]) {
      return false;
    }
  }
  return true;
}
function displayMessage() {
  if (isAnagrams('listen', 'silent')) console.log('They are anagrams');
  else console.log('They are not anagrams');
}
displayMessage(isAnagrams('listen', 'silent'));
console.log(isAnagrams('abc', 'def'));
console.log(isAnagrams('Eleven plus two', 'Twelve plus one'));
