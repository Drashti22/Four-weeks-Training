import { Component } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';  //reactive
@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title = 'Forms';
  // template driven
  userLogin(item: any){
    console.warn(item);
  }
  // reactive
  login=new FormGroup({
    user: new FormControl('', [Validators.required, Validators.email],  ),
    password: new FormControl('', [Validators.required, Validators.minLength(5)])

  })
  loginUser(){
    console.warn(this.login.value)
  }
  get user(){
    return this.login.get('user')
  }
  get password(){
    return this.login.get('password')
  }
}
