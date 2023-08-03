import { Component } from '@angular/core';
import { GreetingService } from '../services/greeting.service';

@Component({
  selector: 'app-greeting',
  templateUrl: './greeting.component.html',
  styleUrls: ['./greeting.component.css']
})
export class GreetingComponent {
  greeting: string;
  constructor(private greetingService: GreetingService ){
    this.greeting = this.greetingService.getGreeting();
  }
}
