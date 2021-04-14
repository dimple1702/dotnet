import { Component, OnInit } from '@angular/core';
import { NgForm } from '@angular/forms';
import { Router } from '@angular/router';
import { BookModel } from '../Models/book.model';
import { BooksService } from '../Services/books.service';

@Component({
  selector: 'app-owner-main-page',
  templateUrl: './owner-main-page.component.html',
  styles: [
  ]
})
export class OwnerMainPageComponent implements OnInit {
  
  constructor(private router: Router, public service: BooksService) { }
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

    DeleteBook(id : number){
      console.log("Krdo delete " + id);
      alert("Are you sure you want to delete this book??");
      this.service.DeleteBook(id).subscribe(
        res =>{
          console.log("Book is Deleted")
        },
        err => {
          console.log(err);
          alert(err);
        }
      )
      window.location.reload();
    }

    EditBook(id : number){
      localStorage.setItem('bookid',id.toString());
      this.router.navigateByUrl('/editBook');
    }
  }
