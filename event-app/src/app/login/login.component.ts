import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { UserData } from '../models/UserData';
import { AuthService } from '../services/auth.service';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html'
})
export class LoginComponent {

  loginUserData: UserData = new UserData();
  constructor(private _auth: AuthService, private _router: Router) { }
  loginUser() {
    this._auth.loginUser(this.loginUserData).subscribe(res => {
      localStorage.setItem('token', res.token)
      this._router.navigate(['/special'])
    },
      err => console.log(err));
  }
}
