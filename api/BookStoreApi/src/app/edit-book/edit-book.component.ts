import { Component, OnInit } from '@angular/core';
import { FormBuilder, Validators } from '@angular/forms';
import { Router } from '@angular/router';
import { BookModel } from '../Models/book.model';
import { BooksService } from '../Services/books.service';

@Component({
  selector: 'app-edit-book',
  templateUrl: './edit-book.component.html',
  styles: [
  ]
})
export class EditBookComponent implements OnInit {

  newBook: BookModel | any;
  constructor(private fb: FormBuilder, public service: BooksService, private router: Router) { }

  getProbablyNumberFromLocalStorage(key: any) {
    var val = localStorage.getItem(key);
    return (val == null || isNaN(+val)) ? val : +val;
  }
  book: any;
  ngOnInit() {

    this.newBook = this.fb.group({
      bookId: [],
      bookName: ['', [Validators.minLength(5), Validators.required]],
      bookAuthor: ['', [Validators.required, Validators.minLength(3)]],
      bookSummary: ['', [Validators.required, Validators.minLength(50)]],
      bookImage: [''],
      bookPrice: ['', Validators.required]
    })

    var temp = this.getProbablyNumberFromLocalStorage("bookid");

    this.service.GetBookById(temp).subscribe(
      res => {

        this.book = res;

        this.newBook.get("bookName").setValue(this.book.bookName);
        this.newBook.get("bookAuthor").setValue(this.book.bookAuthor);
        this.newBook.get("bookSummary").setValue(this.book.bookSummary);
        this.newBook.get("bookImage").setValue(this.book.bookImage);
        this.newBook.get("bookPrice").setValue(this.book.bookPrice);
        this.newBook.get("bookId").setValue(localStorage.getItem('bookid'));
        console.log("this book is " + this.book.bookName);
      },
      err => {
        console.log(err);
      }

    )
    // this.newBook.bookname = "THE GAME OF THRONES";
  }

  UpdateBook(newBook: BookModel | any) {
    console.log("Adding waiiittt");
    console.log(newBook.value.bookName);
    this.service.UpdateBook(newBook.value).subscribe(
      res => {

        this.router.navigateByUrl('/ownermain');
      },
      err => { console.log(err); }
    );
  }


}
