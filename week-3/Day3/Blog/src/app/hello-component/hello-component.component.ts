import { Component } from '@angular/core';

import { OnInit } from "@angular/core";


@Component({
  selector: 'app-hello-component',
  templateUrl: './hello-component.component.html',
  styleUrls: ['./hello-component.component.css']
})
export class HelloComponentComponent  {
  name= "Drashti";
  data= "hi from hello Component";
  
  color= 'red'
  changeColor(){
    this.color = this.randomColor()
  }
  randomColor():string{
    const letters ='0123456789ABCDEF'
    let color = '#'         
    for (let i=0; i<6; i++){
     color+= letters[Math.floor(Math.random() * 16)];
    }
    return color;
  }
  currentItem ='Television'
} 
