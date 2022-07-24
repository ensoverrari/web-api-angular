import { ViewEncapsulation } from '@angular/compiler';
import { Component, OnInit } from '@angular/core';
import { User } from 'src/app/models/user.model';
import { UsersService } from './service/users.service';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css'],
  encapsulation: ViewEncapsulation.None
})
export class AppComponent implements OnInit{
  title = 'users';
  users:User[]=[];
  user:User={
    userID: '',
    name: '',
    lastName: '',
    address: ''
  }
  onSubmit(){

  }

  constructor(private usersService:UsersService)
  {

  }
  ngOnInit(): void {
    this.getAllUsers(); 
  }
  getAllUsers()
  {
    this.usersService.getAllUsers()
    .subscribe(
      response =>{
        this.users=response;
        
      }
    );
  }



}
