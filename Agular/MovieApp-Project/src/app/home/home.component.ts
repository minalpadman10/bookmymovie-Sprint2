import { Component, OnInit } from '@angular/core';
import { Movie } from '../models/Movie';
import { MovieService } from '../services/movie.service';
import { HttpClient,HttpEvent } from '@angular/common/http';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.css']
})
export class HomeComponent implements OnInit {
  httpc: any;

  constructor(private _movieservice: MovieService) { }

  movies: Array<Movie> = new Array<Movie>();
  ngOnInit(): void {

    this._movieservice.getMovies().subscribe(res => this.movies = res, err => console.log(err))
  }
  uploadFile=(files:any)=>{
    console.log("Hi");
    
    if(files.length==0){
      return;
    }
    let filetoUpload=<File>files[0];
    const formData=new FormData();
    formData.append('file',filetoUpload,filetoUpload.name)
    this.httpc.post("https://localhost:44374/api/upload",formData).subscribe((res: any)=>console.log(res),(res: any)=>console.log(res));
  }

}