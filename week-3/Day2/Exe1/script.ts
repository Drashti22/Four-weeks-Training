
function greet( name: string): string{
  return `Hello, ${name}!`
}
console.log(greet("Drashti Sataki"));
console.log(greet("Rushi Sheth"));
console.log(greet("Aditi Modi"))

interface Person{
   (firstName: string,
    lastName: string, 
    age: number): void
}
function addPerson(firstName: string, lastName: string, age: number): void{
    console.log(`${firstName} ${lastName} is ${age} years old.`)
}
let addedPerson: Person = addPerson;
addedPerson('Drashti', 'Sataki', 21 );

class car{
  carMake: string;
  carModel: string;
  carYear: number;

  constructor(make: string, model:string, year: number){
    this.carMake = make;
    this.carModel = model;
    this.carYear = year
  }
}

function displayCarInfo(make: string, model: string, year: number){
  const carDetails = document.getElementById("carDetails")
  if (carDetails) {
  carDetails.textContent= `${make} ${model} ${year}`
}
displayCarInfo("BMW", "X5" , 2023)

function displayInput() {
  const userInput = (document.getElementById("userInput") as HTMLInputElement).value;
  const outputDiv = document.getElementById("output");

  if (outputDiv) {
    if (userInput) {
      outputDiv.textContent = `You entered: ${userInput}`;
    } else {
      outputDiv.textContent = "Please enter something.";
    }
  }
}
}
function getLength(input: string |any[]):number{
  return input.length
}
const arr= ["drashti", "rushi", 1 ]
const str = getLength(arr)
console.log(`lenghth of the "${arr}" is "${str}"`)

