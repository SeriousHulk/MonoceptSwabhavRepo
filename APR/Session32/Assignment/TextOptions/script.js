function displayText() {
  var inputText = document.getElementById('myTextBox').value;
  document.getElementById('output').textContent = inputText;
}

function changeFontSize() {
  var fontSize = document.getElementById('slider').value;
  document.getElementById('output').style.fontSize = fontSize + 'px';
}

function changeTextColor() {
  var textColor = document.getElementById('textColorSelect').value;
  document.getElementById('output').style.color = textColor;
}

function changeBgColor() {
  var bgColor = document.getElementById('bgColorSelect').value;
  document.getElementById('output').style.backgroundColor = bgColor;
}
