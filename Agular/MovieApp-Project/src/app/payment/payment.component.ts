import { Component, OnInit } from '@angular/core';
import { MovieService } from '../services/movie.service';
import { AddmovieService } from '../services/addmovie.service';

@Component({
  selector: 'app-payment',
  templateUrl: './payment.component.html',
  styleUrls: ['./payment.component.css']
})
export class PaymentComponent implements OnInit {

  constructor(private _movieservice: MovieService,private addmovieService : AddmovieService) { }

  public movies : any ; 
  ngOnInit(): void {
    this._movieservice.getMovies().subscribe(res => this.movies = res, err => console.log(err))
  }
  
  addtoaddmovie(movie: any){
    this.addmovieService.addtoMovie(movie);
   }
  
}