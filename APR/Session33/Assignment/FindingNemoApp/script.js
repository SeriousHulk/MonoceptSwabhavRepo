let nemoBoxIndex;
let attempts = 0;
let noOfBoxes = document.querySelector('.collection');
const container = document.querySelector('.container');

function startGame() {
  document.getElementById('task-form').addEventListener('submit', (event) => {
    event.preventDefault();
    const taskInput = document.getElementById('task-input');
    if (taskInput.value === '') {
      alert('Please enter a value');
    } else {
      for (let i = 1; i <= taskInput.value; i++) {
        const box = document.createElement('div');
        box.className = 'box';
        box.id = `box${i}`;
        container.appendChild(box);
      }
    }
  });
  const boxes = document.querySelectorAll('.box');
  boxes.forEach((box) => {
    box.style.backgroundColor = 'silver';
    box.style.backgroundImage = '';
  });

  nemoBoxIndex = Math.floor(Math.random() * boxes.length);
  boxes.forEach((box) => box.addEventListener('mousedown', checkBox));
}

function checkBox(event) {
  const boxes = document.querySelectorAll('.box');
  const clickedBoxIndex = Array.from(boxes).indexOf(event.target);
  if (clickedBoxIndex === nemoBoxIndex) {
    boxes[clickedBoxIndex].style.backgroundImage =
      'url("data:image/jpeg;base64,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")';
    boxes[clickedBoxIndex].style.backgroundSize = 'contain';
    boxes[clickedBoxIndex].style.backgroundPosition = 'center';
    boxes[clickedBoxIndex].style.backgroundRepeat = 'no-repeat';
    boxes[clickedBoxIndex].style.align = 'center';
    alert('Congratulations! You found Nemo.');
    resetGame();
  } else {
    boxes[clickedBoxIndex].style.backgroundColor =
      clickedBoxIndex < nemoBoxIndex ? 'green' : 'red';
    attempts++;
    if (attempts === 3) {
      alert('Game over! You did not find Nemo.');
      resetGame();
    }
  }
}

function resetGame() {
  boxes.forEach((box) => {
    if (box.removeEventListener) {
      box.removeEventListener('click', checkBox);
    }
  });
  attempts = 0;
}
