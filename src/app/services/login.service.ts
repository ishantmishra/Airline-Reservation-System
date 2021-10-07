import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class LoginService {
readonly APIUrl="https://localhost:44310/api";

  constructor(private http:HttpClient) { }

  addRegister(val:any){
    return this.http.post(this.APIUrl+'/Register',val);
  }
  getRegister(val:any){
    return this.http.get(this.APIUrl+'/Register',val);
  }

  
}