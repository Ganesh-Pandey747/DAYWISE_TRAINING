import { Component } from '@angular/core';
import { UserServiceService } from '../Service/user-service.service';

@Component({
  selector: 'app-register',
  templateUrl: './register.component.html',
  styleUrls: ['./register.component.css']
})
export class RegisterComponent {

  registerUserData={

    fullName:'',
    email:'',
    password:''
  
  };

  constructor(private userService:UserServiceService) 
  { 

  }

  registerUser():void
  {
    // console.log(this.registerUser);
    this.userService.CreateAccount(this.registerUserData).subscribe(ctr=>{
      // Data comes here
      console.log(ctr);
    },err=>{
      //error goes here
      console.log(err);
    })
  }

}
