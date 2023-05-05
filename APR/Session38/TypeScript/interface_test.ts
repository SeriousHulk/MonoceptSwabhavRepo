interface ICustomer
{
    id : number,
    firstName : string,
    lastName : string,
    location? : string
}
let customers : ICustomer[];
customers = [
    {id: 101, firstName : "TS", lastName : "Cena"},
    {id: 102, firstName : "RK", lastName : "Tor"},
    {id: 103, firstName : "JP", lastName : "Shaw"}
]
printDetails(customers)

function printDetails(customers : ICustomer[]){
    for(let c in customers)
    {
        console.log(c);
    }
    for(let c of customers)
    {
        console.log(c.firstName);
    }
}