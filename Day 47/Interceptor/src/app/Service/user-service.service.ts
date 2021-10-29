import { Injectable } from '@angular/core';
import { HttpClient ,HttpResponse ,HttpHeaders} from '@angular/common/http';
import { analyzeAndValidateNgModules } from '@angular/compiler';
import { Observable, throwError } from 'rxjs';
import { book } from '../Models/book';
import {catchError, map} from 'rxjs/operators';




@Injectable({
  providedIn: 'root'
})
export class UserServiceService {

   ServiceEndPointR: any ='http://localhost:5000/api/Auth/register';
   ServiceEndPointL: any ='http://localhost:5000/api/Auth/login';
   BookEndPoint:any='https://localhost:5001/api/Book';
   BookSearch:any='http://localhost:5000/api/Book/';
   

  constructor(private httpClient:HttpClient)
  {

  }

  CreateAccount(reg:any)  //:Observable<any>
  {// If a Fucnction return type is observable it means to access the data from this fumtion 
    //or to give the data to function we have to subscribe.

    return this.httpClient.post(this.ServiceEndPointR,reg);
  }

  LoginAccount(login:any)  //:Observable<any>
  {// If a Fucnction return type is observable it means to access the data from this fumtion 
    //or to give the data to function we have to subscribe.

    return this.httpClient.post(this.ServiceEndPointL,login);
  }
  GetBookDetails():Observable<book[]>
  {
    var x:any;

    x=sessionStorage.getItem('Token');
    var headers_object = new HttpHeaders({
      'Content-Type': 'application/json',
       'Authorization': "Bearer "+x
    });

        const httpOptions = {
          headers: headers_object
        };

   
    return this.httpClient.get<book[]>(this.BookEndPoint);
    
  }

  loggedIn()
  {

  return sessionStorage.getItem('Token');
  }

  SearchBookByID(id:any):Observable<book>
  {
    var x:any;
    var headers_object = new HttpHeaders({
      'Content-Type': 'application/json',
       'Authorization': "Bearer "+x
    });

        const httpOptions = {
          headers: headers_object
        };

      return this.httpClient.get<book>("http://localhost:5000/api/Book/"+id).pipe(
      catchError(err => {
          console.log('Handling error locally and rethrowing it...', err);
          return throwError(err);
      })
  )
  }
}