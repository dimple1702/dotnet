import { NgModule} from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { LoginComponent } from './login/login.component';
import { SignupComponent } from './signup/signup.component';
import { OwnerMainPageComponent } from './owner-main-page/owner-main-page.component';
import { VisitorMainPageComponent } from './visitor-main-page/visitor-main-page.component';
import { ManageCoOwnerComponent } from './manage-co-owner/manage-co-owner.component';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { HttpClientModule } from '@angular/common/http';
import { AddNewBookComponent } from './add-new-book/add-new-book.component';
import { AddCoOwnerComponent } from './add-co-owner/add-co-owner.component';
import {NgbModule} from '@ng-bootstrap/ng-bootstrap';
import {BrowserAnimationsModule} from '@angular/platform-browser/animations';
import { ToastrModule } from 'ngx-toastr';
import { MyBookListComponent } from './my-book-list/my-book-list.component';
import { EditBookComponent } from './edit-book/edit-book.component';
import { ReadBookComponent } from './read-book/read-book.component';
import { ViewCommentsComponent } from './read-book/view-comments/view-comments.component';
import { AddCommentsComponent } from './read-book/view-comments/add-comments/add-comments.component';


@NgModule({
  declarations: [
    AppComponent,
    LoginComponent,
    SignupComponent,
    OwnerMainPageComponent,
    VisitorMainPageComponent,
    ManageCoOwnerComponent,
    AddNewBookComponent,
    AddCoOwnerComponent,
    MyBookListComponent,
    EditBookComponent,
    ReadBookComponent,
    ViewCommentsComponent,
    AddCommentsComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,    
    FormsModule,
    ReactiveFormsModule,
    HttpClientModule,
    NgbModule,
    BrowserAnimationsModule,
    ToastrModule.forRoot()
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
