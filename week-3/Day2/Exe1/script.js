"use strict";
function greet(name) {
    return "Hello, ".concat(name, "!");
}
console.log(greet("Drashti Sataki"));
console.log(greet("Rushi Sheth"));
console.log(greet("Aditi Modi"));
function addPerson(firstName, lastName, age) {
    console.log("".concat(firstName, " ").concat(lastName, " is ").concat(age, " years old."));
}
var addedPerson = addPerson;
addedPerson('Drashti', 'Sataki', 21);
var car = /** @class */ (function () {
    function car(make, model, year) {
        this.carMake = make;
        this.carModel = model;
        this.carYear = year;
    }
    return car;
}());
function displayCarInfo(make, model, year) {
    var carDetails = document.getElementById("carDetails");
    if (carDetails) {
        carDetails.textContent = "".concat(make, " ").concat(model, " ").concat(year);
    }
    displayCarInfo("BMW", "X5", 2023);
    function displayInput() {
        var userInput = document.getElementById("userInput").value;
        var outputDiv = document.getElementById("output");
        if (outputDiv) {
            if (userInput) {
                outputDiv.textContent = "You entered: ".concat(userInput);
            }
            else {
                outputDiv.textContent = "Please enter something.";
            }
        }
    }
}
function getLength(input) {
    return input.length;
}
var arr = ["drashti", "rushi", 1];
var str = getLength(arr);
console.log("lenghth of the \"".concat(arr, "\" is \"").concat(str, "\""));
//# sourceMappingURL=script.js.map