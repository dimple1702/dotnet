import { Component, OnInit } from '@angular/core';
import { FormBuilder, NgForm, Validators } from '@angular/forms';
import { Router } from '@angular/router';
import { ToastrService } from 'ngx-toastr';
import { User } from '../Models/user.model';
import { AccountService } from '../Services/accounts.service';

@Component({
  selector: 'app-signup',
  templateUrl: './signup.component.html',
  styles: [
  ]
})
export class SignupComponent implements OnInit {

  signupForm: User | any;
  usernamePattern = "^[a-z0-9._%+-]+@[a-z0-9.-]+\.[a-z]{2,4}$";
  pwdPattern = "^[a-zA-Z0-9]{8,}$";
  isValidFormSubmitted = null;

  constructor(private fb: FormBuilder, public service : AccountService, 
      private router : Router, private toastr : ToastrService) { }


  ngOnInit() {
    this.signupForm = this.fb.group({
      userName: ['', [ Validators.required, Validators.pattern(this.usernamePattern)]],
      userFullName: ['',[Validators.required, Validators.minLength(3)]],
      userAddress: ['',[Validators.required, Validators.minLength(20)]],
      password: ['', [Validators.required,Validators.pattern(this.pwdPattern)]],
      
    })
  }

  SignupUser(form : NgForm){
     console.log("aage g aage" + form.value);
      this.service.Signup(form).subscribe(
        res => {
          this.resetForm(form.value);
          this.toastr.success("You have signed up successfully!! ","Please login to move further");
        },
        err => {console.log(err);}
      );
  }

  resetForm(form : NgForm){
    form.form.reset();
    this.service.formData = new User()
  }
}
