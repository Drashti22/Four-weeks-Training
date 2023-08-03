import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { HttpClientModule } from '@angular/common/http';
import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { PostsComponent } from './posts/posts.component';
import { ParentComponent } from './parent/parent.component';
import { ChildComponent, ChildServiceService } from './child/child.component';
import { MyServiceService } from './services/my-service.service';
import { BinaryPipe } from './pipes/binary.pipe';
import { HexadecimalPipe } from './pipes/hexadecimal.pipe';
import { OctalEquivalentPipe } from './pipes/octal-equivalent.pipe';
import { PostListComponent } from './post-list/post-list.component';
import { GreetingComponent } from './greeting/greeting.component';
import { GreetingService } from './services/greeting.service';
import { CustomGreetingService } from './services/custom-greeting.service';
import { SpecialGreetingService } from './services/special-greeting.service';



@NgModule({
  declarations: [
    AppComponent,
    PostsComponent,
    ParentComponent,
    ChildComponent,
    BinaryPipe,
    HexadecimalPipe,
    OctalEquivalentPipe,
    PostListComponent,
    GreetingComponent,

  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule
  ],
  providers: [
              {provide: GreetingService, useClass: CustomGreetingService},
              {provide: GreetingService, useValue: {getGreeting: ()=> 'Hello, this is value based greeting !'}},
              SpecialGreetingService,
              {provide: GreetingService, useExisting: SpecialGreetingService},
              {
                provide: GreetingService  ,
                useFactory: (specialGreetingService: SpecialGreetingService)=> specialGreetingService,
                 deps: [SpecialGreetingService],
                },
              MyServiceService,
              ChildServiceService ],
  bootstrap: [AppComponent, GreetingComponent]
})
export class AppModule { }
