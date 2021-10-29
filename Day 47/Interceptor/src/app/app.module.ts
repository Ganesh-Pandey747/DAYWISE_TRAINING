import { Component, NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppComponent } from './app.component';
import { RegisterComponent } from './register/register.component';
import { LoginComponent } from './login/login.component';
import {HttpClientModule, HTTP_INTERCEPTORS} from '@angular/common/http';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { RouterModule,Routes } from '@angular/router';
import { HomeComponent } from './home/home.component';
import { SecureRoute } from './Guard/secureroute';
import { TokenInterceptor } from './TokenInterceptor';


const MyRoute:Routes=[
  {path:'Register',component:RegisterComponent},
  {path:'Login',component:LoginComponent },
  {path:'Home',component:HomeComponent,canActivate:[SecureRoute]}
]

@NgModule({
  declarations: [
    AppComponent,
    RegisterComponent,
    LoginComponent,
    HomeComponent
  ],
  imports: [
    BrowserModule,
    HttpClientModule,
    FormsModule,
    ReactiveFormsModule,
    RouterModule.forRoot(MyRoute)
  ],
  providers: [
    {
        provide: HTTP_INTERCEPTORS,
        useClass: TokenInterceptor, 
        multi: true
    }
],
  bootstrap: [AppComponent]
})
export class AppModule { }