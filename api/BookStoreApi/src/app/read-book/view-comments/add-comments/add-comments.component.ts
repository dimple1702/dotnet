import { Component, Input, OnInit } from '@angular/core';
import { FormBuilder, Validators } from '@angular/forms';
import { Router } from '@angular/router';
import { VisitorsService } from 'src/app/Services/visitors.service';

@Component({
  selector: 'app-add-comments',
  templateUrl: './add-comments.component.html',
  styles: [
  ]
})
export class AddCommentsComponent implements OnInit {

  @Input() id : number|any;
  
  newComment: any;
  isValidFormSubmitted = null;


  constructor(private fb: FormBuilder, public service: VisitorsService, private router: Router) { }

  ngOnInit(): void {
    this.newComment = this.fb.group({
      comment : ['', [Validators.required, Validators.minLength(10)]],
    })
  }

  AddComment(comment: any){
    console.log(this.id + " " + comment);
    this.service.AddBookComment(3, this.id, comment).subscribe(
      res =>{
        console.log("Adddeddd");
      },
      err => {
        console.log(err);
      }
    )
  }

}
