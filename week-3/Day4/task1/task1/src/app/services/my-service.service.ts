import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class MyServiceService {
  getMessage(): string{
    return 'This is the parent service message';
  }
  constructor() { }
}
