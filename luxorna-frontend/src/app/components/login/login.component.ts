import { Component, OnInit, Injectable } from '@angular/core';
import { Router} from '@angular/router';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
@Injectable()
export class LoginComponent implements OnInit  {

  constructor(private router:Router) { }
  // canActivate(route: import("@angular/router").ActivatedRouteSnapshot, state: import("@angular/router").RouterStateSnapshot): boolean | import("@angular/router").UrlTree | import("rxjs").Observable<boolean | import("@angular/router").UrlTree> | Promise<boolean | import("@angular/router").UrlTree> {
  //   this.router.navigate(['/main'])
  // }

  email="ghada@gmail.com"
  password="123"
  ngOnInit(): void {
  }


  login(){
    console.log("Success")
    // this.router.navigateByUrl('/main')
    // this.router.navigate(['main']);
if( this.email == this.email&& this.password== this.password){
  this.router.navigate(['adminlayout']);
}

   
   

  }

}
