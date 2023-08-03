import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { AuthGaurd} from './gaurds/auth.guard';
import { HomeComponent } from './home/home.component';
const routes: Routes = [
  {path: 'home', component: HomeComponent, canActivate: [AuthGaurd]}

];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
