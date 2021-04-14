import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { Router } from '@angular/router';
import { BookModel } from '../Models/book.model';
import { BooksService } from '../Services/books.service';

@Component({
  selector: 'app-add-new-book',
  templateUrl: './add-new-book.component.html',
  styles: [
  ]
})
export class AddNewBookComponent implements OnInit {

  newBook: BookModel | any;
  constructor(private router : Router, private fb: FormBuilder, public service : BooksService) { }

  ngOnInit() {
    this.newBook = this.fb.group({
      bookName: ['', [Validators.minLength(5), Validators.required]],
      bookAuthor: ['', [Validators.required, Validators.minLength(3)]],
      bookSummary: ['', [Validators.required, Validators.minLength(50)]],
      bookImage: [''],
      bookPrice: ['', Validators.required]
    })
  }

  AddNewBook(newBook : BookModel | any){
    console.log("Adding waiiittt");
    this.service.AddBook(newBook).subscribe(
      res => {
        alert("Book Added!!!");
      },
      err => {console.log(err);}
    );
    this.router.navigateByUrl("/ownermain");
    window.location.reload();
  }

}
