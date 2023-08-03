import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class AuthService {
  private isLoggedIn: boolean = false;

  login(){
    this.isLoggedIn = true;
  }
  logout(){
    this.isLoggedIn = false;
  }
  get isLogIn(): boolean{
    return this.isLoggedIn;
  }
  constructor() { }
}
