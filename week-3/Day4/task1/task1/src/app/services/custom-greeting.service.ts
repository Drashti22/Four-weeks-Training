import { Injectable } from '@angular/core';
import { GreetingService } from './greeting.service';

@Injectable({
  providedIn: 'root'
})
export class CustomGreetingService implements GreetingService{
 getGreeting(): string {
    return 'hello, GoodMorning Drashti here!!'
  }
  
}
