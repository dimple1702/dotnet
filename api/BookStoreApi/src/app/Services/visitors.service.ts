import { HttpClient, HttpParams } from '@angular/common/http';
import { HOST_ATTR } from '@angular/compiler';
import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class VisitorsService {

  constructor(private http:HttpClient) { }
  readonly visitorUrl : any = "http://localhost:57791/api/Account";


  GetMyBookList(userId : number){
    console.log("Getting list");
    return this.http.get(this.visitorUrl + '/GetMyBookList' + "?userId=1");
  }

  AddToMyBookList( userId:  number, bookId : number){
    return this.http.post(this.visitorUrl + '/AddToMyBookList', "?userId=" + userId + "&bookId=" + bookId);
  }

  RemoveBookFromMyList(userId:  number, bookId : number){
    return this.http.delete(this.visitorUrl + '/RemoveBookFromMyList' + "?userId=" + userId + "&bookId=" + bookId);
  }

  GetBookComment(bookId : number){
    return this.http.get(this.visitorUrl + '/GetBookComments' + "?bookId=" + bookId);
  }

  AddBookComment(userId : number, bookId :  number, comment : string){
    console.log("==================");
    console.log(userId + " " + bookId + " " + comment); 
    var httpParams = new HttpParams({
      fromObject:{
       userId:userId.toString(),
       bookId:bookId.toString(),
       comment:comment.toString()
      }
    });
  return this.http.get(this.visitorUrl + '/AddBookComment', {params:httpParams});  }
}
