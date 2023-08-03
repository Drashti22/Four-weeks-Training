import { Component, Injectable, OnInit } from '@angular/core';
import { ChildServiceService } from '../services/child-service.service';
import { MyServiceService } from '../services/my-service.service';

@Component({
  selector: 'app-child',
  templateUrl: './child.component.html',
  styleUrls: ['./child.component.css'],
  providers: [{ provide: MyServiceService, useClass: ChildServiceService }],
})

export class ChildComponent implements OnInit{
  childMessage!: string;
  constructor(private myService: MyServiceService){}
  ngOnInit(): void {
    this.childMessage =this.myService.getMessage();
  }
}
export { ChildServiceService };

