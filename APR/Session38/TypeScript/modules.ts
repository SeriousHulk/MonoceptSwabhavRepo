export class Bank{
    constructor(public name = "HDFC", public location = "Lucknow")
    {}
}
export class Customer
{
    constructor(public name = "Anonymous")
    {}
}
export class Account{
    constructor(public balance = 500)
    {}
}
export class SayHello{
constructor(public name)
{
    console.log(`Hello ${name}`);
}
}