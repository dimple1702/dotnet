import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { OwnerService } from '../Services/owner.service';

@Component({
  selector: 'app-manage-co-owner',
  templateUrl: './manage-co-owner.component.html',
  styles: [
  ]
})
export class ManageCoOwnerComponent implements OnInit {
  
  constructor(private router: Router,public service: OwnerService) { }
  ownerList: any;
  
  ngOnInit(): void {  
    this.service.GetOwnerList().subscribe(
      res => {
        this.ownerList = res;
        console.log(this.ownerList);
      },
      err => {
        console.log(err);
      }
    )
  }
  refresh(): void {
    window.location.reload();
}

  RemoveOwner(userId : number){
      console.log("Are you sure you want to remove this owner?? " + userId);
      this.service.RemoveOwner(userId).subscribe(
        res =>{
          console.log("Owner is Removed")
        },
        err => {
          console.log(err);
          alert(err);
        }
      )
      window.location.reload();
  }
}
