class StudentV1
{
    name : string
    cgpa : number
    constructor(pname = "anonymous", pcgpa = 0)
    {
        this.name = pname,
        this.cgpa = pcgpa;
    }
}
let s1 = new StudentV1();
console.log(s1);
s1.name = "Vikrant"
s1.cgpa = 8
console.log(s1);

class StudentV2
{
    
    constructor(public name : string = "anonymous", public cgpa : number = 0)
    {
        
    }
}
let s2 = new StudentV2()
console.log(s2);
s2.name = "Vikrant";
s2.cgpa = 8.8;

class StudentV3
{
    constructor(private name = "", private cgpa  = 0)
    {
        
    }
    setUserName(pname){
        this.name = pname;
    }
    getUserName(pname){
        this.name = pname;
    }
    setUserCgpa(pcgpa){
        this.cgpa = pcgpa;
    }
}

let s3 = new StudentV3();
s3.setUserName("Vikrant");
s3.setUserCgpa(8.8);
console.log(s3);

class StudentV4
{
    constructor(private name = "", private cgpa  = 0)
    {
        
    }
    set UserName(pname){
        this.name = pname;
    }
    get UserName(){
        return this.name;
    }
    set UserCgpa(pcgpa){
        this.cgpa = pcgpa;
    }
    get UserCgpa(){
        return this.cgpa;
    }
}
let s4 = new StudentV4();
s4.UserName = "Vikrant";
s4.UserCgpa = 8.7;
console.log(s4);