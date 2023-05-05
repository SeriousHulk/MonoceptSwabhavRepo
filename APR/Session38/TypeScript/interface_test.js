var customers;
customers = [
    { id: 101, firstName: "TS", lastName: "Cena" },
    { id: 102, firstName: "RK", lastName: "Tor" },
    { id: 103, firstName: "JP", lastName: "Shaw" }
];
printDetails(customers);
function printDetails(customers) {
    for (var c in customers) {
        console.log(c);
    }
    for (var _i = 0, customers_1 = customers; _i < customers_1.length; _i++) {
        var c = customers_1[_i];
        console.log(c.firstName);
    }
}
