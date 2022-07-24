import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { User } from 'src/app/models/user.model';

@Injectable({
  providedIn: 'root'
})
export class UsersService {

  baseURL='https://localhost:44342/api/users';
  
  constructor(private http:HttpClient) { }

  //tüm kullanıcıları getir
  getAllUsers():Observable<User[]>
  {
    return this.http.get<User[]>(this.baseURL)
  }

  saveUser(user:User):Observable<User>
  {
    user.userID='00000000-0000-0000-0000-000000000000';
    return this.http.post<User>(this.baseURL,user)
  }

 
}
