import { Component, OnInit } from '@angular/core';
import { Observable } from 'rxjs';
import { book } from '../Models/book';
import { UserServiceService } from '../Service/user-service.service';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.css']
})
export class HomeComponent  {

  Book:book[]=[];
  BookObj!: book;
  Bid!:Number;
  Mess:string='';
  constructor(private userService:UserServiceService)
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
      SearchBook()
      {
        this.userService.SearchBookByID(this.Bid).subscribe(response =>
          {
            this.BookObj = response;
            if(!response)
            {
              this.Mess='No Data Found'
              
            }
            
            this.BookObj = response;
            
          },
          err => 
          {
            this.Mess='No Entry';
            // console.log(err);
          });
      }
  

  // ngOnInit() 
  // {
  //   this.userService.GetBookDetails().subscribe(book=>
  //     {   
  //       this.Book=book;
  //       console.log(this.Book);
  //     },
  //     err=>
  //     {
  //       console.log(err);
       
  //     });  
  // }
}