import { HttpClient, HttpParams } from '@angular/common/http';
import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class OwnerService {

  constructor(private http:HttpClient) { }
  readonly url : any = 'http://localhost:57791/api/Account';


  GetOwnerList(){
    return this.http.get(this.url + '/GetOwnerList');
  }

  GetNonOwnerList(){
    console.log("Non Owner Method in service..");
    return this.http.get(this.url + '/GetNonOwnerList');
  }

  AddOwner(ownerId : number){
    var httpParams = new HttpParams({
      fromObject:{
       Id:ownerId.toString()
      }
    });
    return this.http.get(this.url + '/AddOwner', {params:httpParams});
  }

  RemoveOwner(owner : number){
    var httpParams = new HttpParams({
      fromObject:{
       userId:owner.toString()
      }
    });
    return this.http.get(this.url + '/RemoveOwner', {params:httpParams});
  }
}


