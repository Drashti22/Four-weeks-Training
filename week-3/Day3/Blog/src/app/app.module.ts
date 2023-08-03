import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { HelloComponentComponent } from './hello-component/hello-component.component';
import { NestComponentComponent } from './nest-component/nest-component.component';

@NgModule({
  declarations: [
    AppComponent,
    HelloComponentComponent,
    NestComponentComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
