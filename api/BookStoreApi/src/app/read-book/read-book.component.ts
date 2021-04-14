import { Component, OnInit } from '@angular/core';
import { FormBuilder } from '@angular/forms';
import { Router } from '@angular/router';
import { BookModel } from '../Models/book.model';
import { BooksService } from '../Services/books.service';

@Component({
  selector: 'app-read-book',
  templateUrl: './read-book.component.html',
  styles: [
  ]
})
export class ReadBookComponent implements OnInit {

  constructor(public service: BooksService, private router: Router) { }

  getProbablyNumberFromLocalStorage(key: any) {
    var val = localStorage.getItem(key);
    return (val == null || isNaN(+val)) ? val : +val;
  }
  book: any;
  ngOnInit() {

    var temp = this.getProbablyNumberFromLocalStorage("bookid");

    this.service.GetBookById(temp).subscribe(
      res => {
        this.book = res;
        console.log(this.book);
      },
      err => {
        console.log(err);
      }
    )
  }
}
