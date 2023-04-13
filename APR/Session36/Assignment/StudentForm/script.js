function saveData() {
  var name = document.forms['myForm']['name'].value;
  var gender = document.forms['myForm']['gender'].value;
  var branch = document.forms['myForm']['branch'].value;
  var cgpa = parseFloat(document.forms['myForm']['cgpa'].value);

  if (isNaN(cgpa) || cgpa < 0 || cgpa > 10.0) {
    alert('CGPA must be a number between 0 and 10.0');
    return;
  }

  var student = {
    name: name,
    gender: gender,
    branch: branch,
    cgpa: cgpa,
  };

  var students = localStorage.getItem('students');
  if (!students) {
    students = [];
  } else {
    students = JSON.parse(students);
  }

  students.push(student);
  localStorage.setItem('students', JSON.stringify(students));
  displayData();
}

function displayData() {
  var students = localStorage.getItem('students');
  if (students) {
    students = JSON.parse(students);
    var table = document.createElement('table');
    var headerRow = table.insertRow(0);
    headerRow.innerHTML =
      '<th>Name</th><th>Gender</th><th>Branch</th><th>CGPA</th>';

    for (var i = 0; i < students.length; i++) {
      var student = students[i];
      var row = table.insertRow(i + 1);
      row.innerHTML =
        '<td>' +
        student.name +
        '</td><td>' +
        student.gender +
        '</td><td>' +
        student.branch +
        '</td><td>' +
        student.cgpa +
        '</td>';
    }

    var displayDiv = document.getElementById('display');
    displayDiv.innerHTML = '';
    displayDiv.appendChild(table);
  }
}
