var functionPtr = function f1() {
  console.log('inside f1');
};

var functionPtr1 = functionPtr;

functionPtr();

functionPtr = function f2() {
  console.log('inside f2');
};
functionPtr();

function doSomething(callback_pointer) {
  console.log('doing something!');
  console.log('completed something!');
  callback_pointer();
}

doSomething;

doSomething(function () {
  console.log('Inside annonymas Function');
});

doSomething( () => {
  console.log('Inside Lambda Function');
});

setTimeout(function () {
  console.log('Inside annonymas Function 2 after 3 sec');
}, 3000);
