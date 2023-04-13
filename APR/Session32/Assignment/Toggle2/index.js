var checkbox = document.getElementById('hideCheckbox');
var image = document.getElementById('imgPicture');
checkbox.addEventListener('change', function () {
  if (checkbox.checked) {
    image.style.display = 'none';
  } else {
    image.style.display = 'block';
  }
});
