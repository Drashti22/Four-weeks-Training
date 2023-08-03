import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export abstract class GreetingService {
  abstract getGreeting(): string 
    // return 'Hello, Drashti Here !!!'
}
