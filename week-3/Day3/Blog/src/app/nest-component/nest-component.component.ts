import { Component, OnInit, Input } from '@angular/core';


@Component({
  selector: 'app-nest-component',
  templateUrl: './nest-component.component.html',
  styleUrls: ['./nest-component.component.css']
})
export class NestComponentComponent{
  @Input() item ='';
  // constructor(){

  // }

} 
