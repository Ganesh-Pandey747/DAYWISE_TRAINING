import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http'
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class UserServiceService {

  serviceEndpointR: any = 'https://localhost:5001/api/Auth/register';
  serviceEndpointL: any = 'https://localhost:5001/api/Auth/login';
  BookEndPoint: any = 'https://localhost:5001/api/Book';

  constructor(private httpClient: HttpClient) 
  {
  }

  createAccount(reg: any)
  {
    /* if a function return type is observable it means to access the data from this function 
    or to give the data to the function we have to subscribe. */
    return this.httpClient.post(this.serviceEndpointR, reg);
  }

  loginAccount(login: any)
  {
    /* if a function return type is observable it means to access the data from this function 
    or to give the data to the function we have to subscribe. */
    return this.httpClient.post(this.serviceEndpointL, login);
  }
  
  loggedIn()
  {
    return sessionStorage.getItem('Token');
  }

  GetBookDetails()
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

   
    return this.httpClient.get(this.BookEndPoint,httpOptions);
    
  }
}
