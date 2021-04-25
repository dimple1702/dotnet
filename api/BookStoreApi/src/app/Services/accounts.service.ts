import { Injectable } from '@angular/core';
import {HttpClient} from '@angular/common/http';
import { User } from '../Models/user.model';
import { Router } from '@angular/router';

@Injectable({
  providedIn: 'root'
})
export class AccountService {

  constructor(private http:HttpClient) { }

  readonly loginURL : any = "http://localhost:57791/api/Account/Login";
  readonly signupURL : any = "http://localhost:57791/api/Account/SignUp";
  formData : User = new User();

  Login(form : any){
    console.log("valuess??? "+form.value);
    return this.http.post(this.loginURL, this.formData);
  }

  Signup(form : User | any){
    console.log(form.value);
    return this.http.post(this.signupURL,form.value);
  }
}
