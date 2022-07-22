import { Component } from '@angular/core';
import { AuthService } from './services/auth.service';
import { AddmovieService } from './services/addmovie.service';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  public totalItem : number = 1;
  constructor(private _auth:AuthService,private addmovieservice:AddmovieService){ }

  ngOnInit(): void {
    this.addmovieservice.getMovies()
    .subscribe(res=>{
      this.totalItem = res.length;
    })
  }

  title = 'Book My Movie';


  LoggedIn(input:boolean): boolean{
    if(input){
      return this._auth.loggedIn();
    }
    else{
      return !this._auth.loggedIn();
    }
  }
  LogOut(){
    this._auth.logoutUser();
  }
}