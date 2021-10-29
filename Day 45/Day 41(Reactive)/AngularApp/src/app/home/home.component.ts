import { Component, OnInit } from '@angular/core';
import { UserServiceService } from '../Service/user-service.service';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.css']
})
export class HomeComponent implements OnInit {

  Book:any;
  constructor(private userService:UserServiceService)
  {

  }

  ngOnInit() 
  {
    this.userService.GetBookDetails().subscribe(book=>
      {   
        this.Book=book;
        console.log(this.Book);
      },
      err=>
      {
        console.log(err);
       
      });  
  }
}
