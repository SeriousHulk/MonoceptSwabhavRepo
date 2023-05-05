var StudentV1 = /** @class */ (function () {
    function StudentV1(pname, pcgpa) {
        if (pname === void 0) { pname = "anonymous"; }
        if (pcgpa === void 0) { pcgpa = 0; }
        this.name = pname,
            this.cgpa = pcgpa;
    }
    return StudentV1;
}());
var s1 = new StudentV1();
console.log(s1);
s1.name = "Vikrant";
s1.cgpa = 8;
console.log(s1);
var StudentV2 = /** @class */ (function () {
    function StudentV2(name, cgpa) {
        if (name === void 0) { name = "anonymous"; }
        if (cgpa === void 0) { cgpa = 0; }
        this.name = name;
        this.cgpa = cgpa;
    }
    return StudentV2;
}());
var s2 = new StudentV2();
console.log(s2);
s2.name = "Vikrant";
s2.cgpa = 8.8;
var StudentV3 = /** @class */ (function () {
    function StudentV3(name, cgpa) {
        if (name === void 0) { name = ""; }
        if (cgpa === void 0) { cgpa = 0; }
        this.name = name;
        this.cgpa = cgpa;
    }
    StudentV3.prototype.setUserName = function (pname) {
        this.name = pname;
    };
    StudentV3.prototype.getUserName = function (pname) {
        this.name = pname;
    };
    StudentV3.prototype.setUserCgpa = function (pcgpa) {
        this.cgpa = pcgpa;
    };
    return StudentV3;
}());
var s3 = new StudentV3();
s3.setUserName("Vikrant");
s3.setUserCgpa(8.8);
console.log(s3);
var StudentV4 = /** @class */ (function () {
    function StudentV4(name, cgpa) {
        if (name === void 0) { name = ""; }
        if (cgpa === void 0) { cgpa = 0; }
        this.name = name;
        this.cgpa = cgpa;
    }
    Object.defineProperty(StudentV4.prototype, "UserName", {
        get: function () {
            return this.name;
        },
        set: function (pname) {
            this.name = pname;
        },
        enumerable: false,
        configurable: true
    });
    Object.defineProperty(StudentV4.prototype, "UserCgpa", {
        get: function () {
            return this.cgpa;
        },
        set: function (pcgpa) {
            this.cgpa = pcgpa;
        },
        enumerable: false,
        configurable: true
    });
    return StudentV4;
}());
var s4 = new StudentV4();
s4.UserName = "Vikrant";
s4.UserCgpa = 8.7;
console.log(s4);
