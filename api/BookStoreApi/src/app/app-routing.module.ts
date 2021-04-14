import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { AddCoOwnerComponent } from './add-co-owner/add-co-owner.component';
import { AddNewBookComponent } from './add-new-book/add-new-book.component';
import { EditBookComponent } from './edit-book/edit-book.component';
import { LoginComponent } from './login/login.component';
import { ManageCoOwnerComponent } from './manage-co-owner/manage-co-owner.component';
import { MyBookListComponent } from './my-book-list/my-book-list.component';
import { OwnerMainPageComponent } from './owner-main-page/owner-main-page.component';
import { ReadBookComponent } from './read-book/read-book.component';
import { SignupComponent } from './signup/signup.component';
import { VisitorMainPageComponent } from './visitor-main-page/visitor-main-page.component';

const routes: Routes = [
  {path:'', redirectTo: 'login', pathMatch:'full'},
  {path:'login', component:LoginComponent},
  {path:'signup', component:SignupComponent},
  {path:'ownermain', component:OwnerMainPageComponent},
  {path:'addOwner', component:AddCoOwnerComponent},
  {path:'addnewbook', component:AddNewBookComponent},
  {path:'visitormain', component:VisitorMainPageComponent},
  {path:'manageOwner', component:ManageCoOwnerComponent},
  {path:'myBookList', component:MyBookListComponent},
  {path:'editBook',component: EditBookComponent},
  {path: 'readBook', component:ReadBookComponent}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
