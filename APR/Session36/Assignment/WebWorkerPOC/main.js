var worker = new Worker('factorialWorker.js');
var number = 7;
worker.postMessage(number);

worker.onmessage = function (event) {
  var factorial = event.data;
  console.log('Factorial of ' + number + ' is: ' + factorial);
};

/*  onmessage is an event handler that is used in a web worker to listen for incoming
    messages from the main thread or other web workers. It is a property of the self
    object in the web worker, and you can set it to a function that will be executed
    whenever a message is received by the web worker.                                               */

/*  postMessage is a method that is used in a web worker to send messages back to the 
    main thread or other web workers. It is also a property of the self object in the web 
    worker, and you can call it with the data you want to send as an argument. The data can 
    be of various types, such as strings, numbers, objects, or arrays, and it will be 
    serialized before being sent to the receiving thread.                                               */
