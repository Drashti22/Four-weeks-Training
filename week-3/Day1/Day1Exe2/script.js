function EnterName(){
    var name= prompt("Enter your name: ")
        document.getElementById("msg").innerHTML= "Please Enter you Name "
    }  
    else{
        document.getElementById("msg").innerHTML =
    if(name==null || name==""){
 "Hello, " + name;
    }
}
    var firstNumber;
    var secondNumber;
    var num1;
    var num2;
    var sum;

    
    function AddNumbers(){
    firstNumber=window.prompt("Enter a first Number")
    secondNumber=window.prompt("Enter a second Number")
    num1=parseInt(firstNumber);
    num2=parseInt(secondNumber);
    sum=num1+num2;
    document.writeln("<h1>The sum is : " + sum + "<h1>");
    }
