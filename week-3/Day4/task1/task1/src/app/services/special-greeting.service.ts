import { Injectable } from '@angular/core';
import { GreetingService } from './greeting.service';

@Injectable({
  providedIn: 'root'
})
export class SpecialGreetingService implements GreetingService{
   getGreeting(): string {
    return 'Hello, Good Morning , How are You ?'
  }
}
