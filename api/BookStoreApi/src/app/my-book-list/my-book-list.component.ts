import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { VisitorsService } from '../Services/visitors.service';

@Component({
  selector: 'app-my-book-list',
  templateUrl: './my-book-list.component.html',
  styles: [
  ]
})
export class MyBookListComponent implements OnInit {

  constructor(public service: VisitorsService, private router: Router) { }
  mybookList: any;
  bookId: number|any;

  ngOnInit(): void {
    this.service.GetMyBookList(this.bookId).subscribe(
      res => {
        this.mybookList = res;
        console.log(this.mybookList);
      },
      err => {
        console.log(err);
      })
  }

  ReadBook(id : number){
    localStorage.setItem('bookid',id.toString());
    console.log("ReadBook method " + id);
    this.router.navigateByUrl('/readBook');
  }
}
