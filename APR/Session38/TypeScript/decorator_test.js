var __decorate = (this && this.__decorate) || function (decorators, target, key, desc) {
    var c = arguments.length, r = c < 3 ? target : desc === null ? desc = Object.getOwnPropertyDescriptor(target, key) : desc, d;
    if (typeof Reflect === "object" && typeof Reflect.decorate === "function") r = Reflect.decorate(decorators, target, key, desc);
    else for (var i = decorators.length - 1; i >= 0; i--) if (d = decorators[i]) r = (c < 3 ? d(r) : c > 3 ? d(target, key, r) : d(target, key)) || r;
    return c > 3 && r && Object.defineProperty(target, key, r), r;
};
function NeedToRefactor(description) {
    return function (classConstructor) {
        console.log(description);
        console.log(classConstructor);
    };
}
var Foo = /** @class */ (function () {
    function Foo(description) {
        if (description === void 0) { description = "Foo"; }
        this.description = description;
    }
    Foo = __decorate([
        NeedToRefactor("urgent") //meta data tags, wrapper, additional behaviors
    ], Foo);
    return Foo;
}());
var Baz = /** @class */ (function () {
    function Baz() {
    }
    Baz = __decorate([
        NeedToRefactor()
    ], Baz);
    return Baz;
}());
var Bar = /** @class */ (function () {
    function Bar(description) {
        if (description === void 0) { description = "Foo"; }
        this.description = description;
    }
    Bar = __decorate([
        NeedToRefactor("not urgent")
    ], Bar);
    return Bar;
}());
