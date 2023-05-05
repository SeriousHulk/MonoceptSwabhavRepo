"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
exports.SayHello = exports.Account = exports.Customer = exports.Bank = void 0;
var Bank = /** @class */ (function () {
    function Bank(name, location) {
        if (name === void 0) { name = "HDFC"; }
        if (location === void 0) { location = "Lucknow"; }
        this.name = name;
        this.location = location;
    }
    return Bank;
}());
exports.Bank = Bank;
var Customer = /** @class */ (function () {
    function Customer(name) {
        if (name === void 0) { name = "Anonymous"; }
        this.name = name;
    }
    return Customer;
}());
exports.Customer = Customer;
var Account = /** @class */ (function () {
    function Account(balance) {
        if (balance === void 0) { balance = 500; }
        this.balance = balance;
    }
    return Account;
}());
exports.Account = Account;
var SayHello = /** @class */ (function () {
    function SayHello(name) {
        this.name = name;
        console.log("Hello ".concat(name));
    }
    return SayHello;
}());
exports.SayHello = SayHello;
