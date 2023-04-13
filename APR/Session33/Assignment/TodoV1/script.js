var form = document.querySelector('#task-form');
var taskList = document.querySelector('#task-list');
var taskInput = document.querySelector('#task-input');
var tasks = [];

form.addEventListener('submit', function (e) {
  e.preventDefault();
  var task = taskInput.value.trim();
  if (task !== '') {
    var taskObj = {
      id: Date.now(),
      task: task,
    };
    tasks.push(taskObj);
    renderTask(taskObj);
    taskInput.value = '';
  } else alert('cannot submit empty form');
});

function renderTask(taskObj) {
  var taskItem = document.createElement('li');
  taskItem.className = 'task-item';
  taskItem.textContent = taskObj.task;
  taskList.appendChild(taskItem);
}
