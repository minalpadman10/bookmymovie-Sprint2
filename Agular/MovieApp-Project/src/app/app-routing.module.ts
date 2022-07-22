import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { PaymentComponent } from './payment/payment.component';
import { AddressComponent } from './address/address.component';
import { FinalconfirmationComponent } from './finalconfirmation/finalconfirmation.component';


import { DashboardComponent } from './dashboard/dashboard.component';
import { HomeComponent } from './home/home.component';
import { LoginComponent } from './login/login.component';
import { RegisterComponent } from './register/register.component';
import { AddmovieComponent } from './addmovie/addmovie.component';

const routes: Routes = [
  {
    path: 'home',
    component: HomeComponent
  },
  {
    path: '',
    component: HomeComponent
  },
  {
    path: 'login',
    component: LoginComponent
  },
  {
    path: 'register',
    component: RegisterComponent
  },
  
  {
    path: 'dashboard',
    component: DashboardComponent
  },
  {
    path: 'addmovie',
    component: AddmovieComponent
  },
  {
    path: 'payment',
    component: PaymentComponent
  },
  {
    path: 'address',
    component: AddressComponent
  },
  {
    path: 'finalconfirmation',
    component: FinalconfirmationComponent
  }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }