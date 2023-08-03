import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { HomeComponent } from './home/home.component';
import { AboutComponent } from './about/about.component';
import { BlogComponent } from './blog/blog.component';
import { ContactComponent } from './contact/contact.component';
import { PostDetailsComponent } from './post-details/post-details.component';

const routes: Routes = [
 { path: 'home', component: HomeComponent} ,
 { path: 'about', component: AboutComponent} ,
 { path: 'blog', component: BlogComponent} ,
 {path: 'contact' , component: ContactComponent},
 {path: 'blog/:id' , component: PostDetailsComponent},
 


];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
