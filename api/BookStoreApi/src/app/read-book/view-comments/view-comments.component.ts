import { Component, Input, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { VisitorsService } from 'src/app/Services/visitors.service';

@Component({
  selector: 'app-view-comments',
  templateUrl: './view-comments.component.html',
  styles: [
  ]
})
export class ViewCommentsComponent implements OnInit {

  @Input() id : number | any;
  comments : any;
  isVisible: boolean = true;
  
  constructor(public service: VisitorsService, private router : Router) { }
  
  ngOnInit(): void {
    this.service.GetBookComment(this.id).subscribe(
      res => {
        this.comments = res;
        console.log(this.comments);
      },
      err => {
        console.log(err);
      }
    )
    this.service.GetBookComment(this.id).subscribe(
    )
  }

  switchVisibility() {
    this.isVisible = !this.isVisible;
  }

}
