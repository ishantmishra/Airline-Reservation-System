import { Component, OnInit } from '@angular/core';
import { Register } from '../register/register.model';
import { LoginService } from '../services/login.service';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent implements OnInit {

  register = new Register();

  constructor(private loginservice:LoginService ) {}  

  ngOnInit(): void {
    
  }

  onSubmit(){
    this.loginservice.getRegister(this.register).subscribe(res=>{
      
    })
  }
}
