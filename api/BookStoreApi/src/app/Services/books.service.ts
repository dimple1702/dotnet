import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { BookModel } from '../Models/book.model';

@Injectable({
  providedIn: 'root'
})
export class BooksService {

  constructor(private http:HttpClient) { }
  readonly bookUrl: any = "http://localhost:57791/api/Books";

  book : BookModel = new BookModel();

  GetBooks(){
    return this.http.get(this.bookUrl +'/BookList');
  }

  GetBookById(bookId : number | any){
    return this.http.get(this.bookUrl +'/GetBookById' + "?Id=" + bookId);
  }

  AddBook(book : any){
    console.log("Aggye service mein");
    console.log(book);
    return this.http.post(this.bookUrl +'/AddBook',book.value);
  }

  DeleteBook(id : number){
    console.log("Aggye service mein");
    console.log(id);
    return this.http.delete(this.bookUrl +'/DeleteBook' + "?Id=" + id);
  }

  UpdateBook(data:BookModel)
  {
  console.log(data)
  console.log("ADDDDDDDDDDDDDDDDDDDD")
   return this.http.post(this.bookUrl +'/UpdateBook',data)
  }
}
