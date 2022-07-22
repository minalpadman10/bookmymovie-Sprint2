import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Router } from '@angular/router';

@Injectable({
  providedIn: 'root'
})
export class MovieService {
  private _movieUrl = "https://localhost:44389/api/movie";
  constructor(private http: HttpClient,private _router:Router) { }

  
  getMovies() {
    return this.http.get<any>(this._movieUrl);
  }
}