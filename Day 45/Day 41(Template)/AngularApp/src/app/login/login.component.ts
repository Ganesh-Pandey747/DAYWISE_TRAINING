import { Component } from '@angular/core';
import { Router } from '@angular/router';
import { UserServiceService } from '../Service/user-service.service';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent 
{
  LoginUserData=
  {
  email:'',
  password:''
  }

  dataForAny:any;


constructor(private router:Router ,private userService:UserServiceService) 
{ 

}


LoginUser(): void
  {
    // console.log(this.LoginUserData);
    this.userService.LoginAccount(this.LoginUserData).subscribe(response=>
    {   
      this.dataForAny=response;
      console.log(this.dataForAny);
      sessionStorage.setItem('Token', this.dataForAny.token);
     
      
      this.router.navigate(['/Home']);
    },
    err=>
    {
      console.log(err);
     

    });  
  } 
}