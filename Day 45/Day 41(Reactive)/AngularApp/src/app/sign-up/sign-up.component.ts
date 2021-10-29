import { Component, OnInit } from '@angular/core';
import { FormBuilder, Validators } from '@angular/forms';
import { UserServiceService } from '../Service/user-service.service';

@Component({
  selector: 'app-sign-up',
  templateUrl: './sign-up.component.html',
  styleUrls: ['./sign-up.component.css']
})
export class SignUpComponent implements OnInit {

  signUpForm: any;
  constructor(public formBuilder: FormBuilder, private userService: UserServiceService ) 
  {

  }

  ngOnInit(): void {
    this.signUpForm = this.formBuilder.group({
      FullName: ['', [Validators.required, Validators.minLength(4)]],
      Email: ['', [Validators.required]],
      Password: ['', [Validators.required]]
    })  
  }
  
  get getControl(){
    return this.signUpForm.controls;
  }
  
  onSubmit(){
    console.log(this.signUpForm.value);
    this.userService.createAccount(this.signUpForm.value).subscribe(x=>{
      //data comes here
      console.log(x);
    },err=>{
      //error goes here
      console.log(err);
    })  //signUpForm have the data
  }

}
