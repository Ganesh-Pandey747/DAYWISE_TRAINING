import { Injectable } from "@angular/core";
import { ActivatedRouteSnapshot, CanActivate, Router, RouterStateSnapshot, UrlTree } from "@angular/router";
import { Observable } from "rxjs";
import { UserServiceService } from "../Service/user-service.service";

@Injectable({
    providedIn: 'root'
  })
export class SecureRoute implements CanActivate
{
    constructor(private userService:UserServiceService,private rou:Router)
    {

    }
    canActivate():boolean
    {
        if(this.userService.loggedIn()){
            return true;
          }
          else{
            this.rou.navigate(['/Register'])
            return false;
          }
    }
}