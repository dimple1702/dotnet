import { Component, OnInit } from '@angular/core';
import { FormBuilder, NgForm, Validators } from '@angular/forms';
import { User } from '../Models/user.model';
import { AccountService } from '../Services/accounts.service';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styles: [
  ]
})
export class LoginComponent implements OnInit {


  loginForm: User | any;
  usernamePattern = "^[a-z0-9._%+-]+@[a-z0-9.-]+\.[a-z]{2,4}$";
  pwdPattern = "^[a-zA-Z0-9]{8,}$";
  isValidFormSubmitted = null;

  constructor(private fb: FormBuilder, public service : AccountService) { }


  ngOnInit() {
    this.loginForm = this.fb.group({
      userName: ['', [ Validators.required, Validators.pattern(this.usernamePattern)]],
      password: ['', [Validators.required,Validators.pattern(this.pwdPattern)]]
    })
  }

  LoginUser(form : NgForm){
    this.service.Login(form).subscribe(
      res=>{
        
      },
      err=>{}
    )
  }

}
