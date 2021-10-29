import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { UserServiceService } from '../Service/user-service.service';

@Component({
  selector: 'app-sign-in',
  templateUrl: './sign-in.component.html',
  styleUrls: ['./sign-in.component.css']
})
export class SignInComponent {

  dataForAny: any;
  constructor(private router: Router ,private userService: UserServiceService)
  {

  }

  userSignInData={
    Email:'',
    Password:''
  };

  userSignIn(): void
  {
    this.userService.loginAccount(this.userSignInData).subscribe(resp =>{
      this.dataForAny = resp;
      console.log(this.dataForAny.name);
      sessionStorage.setItem('Token', this.dataForAny.token);
      this.router.navigate(['/home']);
    },err=>{
      console.log(err);
    })
    //if we don't subscribe data will not pass
  }
  

}
