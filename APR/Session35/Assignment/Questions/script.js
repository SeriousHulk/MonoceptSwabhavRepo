let questions = [
  {
    question: 'Is Mumbai in India?',
    answer: 'yes',
  },
  {
    question: 'Does Amitabh Hosts KBC?',
    answer: 'yes',
  },
  {
    question: "Is Nepal India's Neighbour?",
    answer: 'yes',
  },
];

let statement = document.getElementById('statement');
let form = document.getElementById('quizForm');
let result = document.getElementById('result');
let questionCounter = document.getElementById('questionCounter');
let leftBtn = document.getElementById('leftBtn');
let rightBtn = document.getElementById('rightBtn');
let count = 0;
let userAnswers = [];

statement.textContent = questions[count].question;
questionCounter.textContent = `Question ${count + 1} of ${questions.length}`;

rightBtn.addEventListener('click', goRight);
leftBtn.addEventListener('click', goLeft);

function goRight() {
  if (count < questions.length - 1) {
    count++;
    statement.textContent = questions[count].question;
    questionCounter.textContent = `Question ${count + 1} of ${
      questions.length
    }`;
    form.reset();
  }
}

function goLeft() {
  if (count > 0) {
    count--;
    statement.textContent = questions[count].question;
    questionCounter.textContent = `Question ${count + 1} of ${
      questions.length
    }`;
    form.reset();
  }
}

form.addEventListener('submit', function (e) {
  e.preventDefault();
  let selectedAnswer = form.elements.answer.value;
  userAnswers[count] = selectedAnswer;
  if (count < questions.length - 1) {
    goRight();

    form.reset();
  } else {
    let score = 0;
    for (let i = 0; i < questions.length; i++) {
      let question = questions[i];
      if (userAnswers[i] === question.answer) {
        score++;
      }
    }
    result.textContent = `Your score: ${score}/${questions.length}`;
  }
});
