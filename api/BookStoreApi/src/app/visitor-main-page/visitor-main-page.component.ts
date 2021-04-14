import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { BooksService } from '../Services/books.service';
import { VisitorsService } from '../Services/visitors.service';

@Component({
  selector: 'app-visitor-main-page',
  templateUrl: './visitor-main-page.component.html',
  styles: [
  ]
})
export class VisitorMainPageComponent implements OnInit {

  constructor(public service: BooksService) { }
  bookList: any;
  
  ngOnInit(): void {  
    this.service.GetBooks().subscribe(
      res => {
        this.bookList = res;
        console.log(this.bookList);
      },
      err => {
        console.log(err);
      })
    }

}
