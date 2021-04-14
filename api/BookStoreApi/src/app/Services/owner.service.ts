import { HttpClient, HttpParams } from '@angular/common/http';
import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class OwnerService {

  constructor(private http:HttpClient) { }

  readonly getUser : any = "http://localhost:57791/api/Account/GetUser";
  readonly getOwnerList : any = "http://localhost:57791/api/Account/GetOwnerList";
  readonly getNonOwnerList : any = "http://localhost:57791/api/Account/GetNonOwnerList";
  readonly addOwner : any = "http://localhost:57791/api/Account/AddOwner";
  readonly removeOwner : any = "http://localhost:57791/api/Account/RemoveOwner";


  GetOwnerList(){
    return this.http.get(this.getOwnerList);
  }

  GetNonOwnerList(){
    console.log("Non Owner Method in service..");
    return this.http.get(this.getNonOwnerList);
  }

  AddOwner(ownerId : number){
    var httpParams = new HttpParams({
      fromObject:{
       Id:ownerId.toString()
      }
    });
    return this.http.get(this.addOwner, {params:httpParams});
  }

  RemoveOwner(owner : number){
    var httpParams = new HttpParams({
      fromObject:{
       userId:owner.toString()
      }
    });
    return this.http.get(this.removeOwner, {params:httpParams});
  }
}


