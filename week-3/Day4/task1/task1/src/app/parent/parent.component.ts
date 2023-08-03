import { Component, OnInit } from '@angular/core';
import { MyServiceService } from '../services/my-service.service';

@Component({
  selector: 'app-parent',
  templateUrl: './parent.component.html',
  styleUrls: ['./parent.component.css']
})
export class ParentComponent implements OnInit {
  decimalNumber: number = 42;
  parentMessage!: string;
  constructor(private myService: MyServiceService){}
  ngOnInit(): void {
    this.parentMessage =this.myService.getMessage();
  }
}
