import { Component, OnInit } from '@angular/core';
import { FormGroup, Validators, FormControl} from '@angular/forms';
import { Router } from '@angular/router';


import { Observable } from 'rxjs';
import { LoginComponent } from '../login/login.component';
import { LoginService } from '../services/login.service';
import { Register } from './register.model';




@Component({
  selector: 'app-register',
  templateUrl: './register.component.html',
  styleUrls: ['./register.component.css']
})
export class RegisterComponent implements OnInit {
 register = new Register();
 


  constructor(private loginservice: LoginService, private router: Router) { }


  ngOnInit(): void {  
  
  }

  submit(){
     this.loginservice.addRegister(this.register).subscribe(res=>{
       console.log("Successfully Registered") 
     })
     
  
      }

    
}