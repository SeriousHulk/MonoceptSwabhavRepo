
function NeedToRefactor(description?:string)
{
    return function(classConstructor: Function) 
    {
        console.log(description);
        console.log(classConstructor);
    }
}


@NeedToRefactor("urgent")  //meta data tags, wrapper, additional behaviors
class Foo{
    constructor(public description = "Foo"){}
}
@NeedToRefactor()
class Baz{

}
@NeedToRefactor("not urgent")
class Bar{
    constructor(public description = "Foo"){}
}