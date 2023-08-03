import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { FormsModule } from '@angular/forms';  //templatedriven
import { ReactiveFormsModule } from '@angular/forms'; //reactive

@NgModule({
  declarations: [
    AppComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    FormsModule, //templatedriven
    ReactiveFormsModule //reactive
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
