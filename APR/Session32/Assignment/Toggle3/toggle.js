function hideShowImage() {
    var img = document.getElementById('myImage');
    var btn = document.getElementById('hideShowBtn');
    
    if (img.style.display === 'none') {
      img.style.display = 'block';
      btn.textContent = 'Hide';
    } else {
      img.style.display = 'none';
      btn.textContent = 'Show';
    }
  }